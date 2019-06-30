var homeconfig = {
    pageSize: 10,
    pageIndex: 1
}

var productController = function () {

    this.Init = function () {
        loadData();
        registerEvent();
    }

    function registerEvent() {  

        //event click create
        $('body').on('click', '#createProduct', function (e) {
            e.preventDefault();
            var product = {};
            product.Name = $('#txtName').val();
            product.Price = parseInt($('#txtPrice').val());
            product.Status = $('#productStatus').is(":checked");
            createProduct(product);
        });

        function createProduct(product) {
            $.ajax({
                url: '/api/ProductAPI',
                type: 'POST',
                dataType: 'json',
                data: product,
                success: function () {
                    alert('Create product successful!');
                    loadData();
                },
                error: function () {
                    console.log('Error in Operation');
                }
            });
        }

        //evevt update product
        $('body').on('click', '#updateProduct', function (e) {
            e.preventDefault();
            var product = {};
            product.Id = $('#txtId').val();
            product.Name = $('#txtName').val();
            product.Price = $('#txtPrice').val();
            product.Status = $('#productStatus').is(":checked");
            updateData(product);
        });

        function updateData(product) {
            $.ajax({
                url: '/api/UpdateProductAPI',
                type: 'PUT',
                dataType: 'json',
                data: product,
                success: function () {
                    alert('Update successed!');
                    loadData();
                },
                error: function () {
                    console.log('Error in Operation');
                }
            });
        }

        //event dalete product
        $('body').on('click', '#deleteProduct', function (e) {
            e.preventDefault();
            var id = parseInt($('#txtId').val());
            deleteProduct(id);
        });

        function deleteProduct(id) {
            $.ajax({
                url: "/api/DeleteAPI?id=" + id  ,
                type: 'DELETE',
                dataType: 'json',
                //data: { id: id },
                success: function () {
                    alert('Delete successed!');
                    loadData();
                },
                error: function () {
                    console.log('Error in Operation');
                }
            });
        }

        //event take data product from field to textbox
        $('body').on('click', '.singleProduct', function (e) {
            e.preventDefault();
            var dataId = $(this).data('id');
            $.ajax({
                url: '/api/ProductAPI',
                type: 'GET',
                dataType: 'json',
                success: function (data) {
                    $(data).each(function (key, value) {
                        if (value.Id == dataId) {
                            $('#txtId').val(value.Id);
                            $('#txtName').val(value.Name);
                            $('#txtPrice').val(value.Price);
                        }
                    });
                }
            });
        });
       
        $('body').on('click', '#searchProduct', function (e) {
            e.preventDefault();
            var txtSearch = $('#txtName').val();
            $.ajax({
                url: '/api/SearchProductAPI',
                type: 'GET',
                data: {
                    txtSearch: txtSearch,
                    page: homeconfig.pageIndex,
                    pageSize: homeconfig.pageSize
                },
                dataType: 'json',
                success: function (response) {
                    $('.ajaxData').remove();
                    var html = '';
                    var template = $('#data-template').html();
                    $(response.data).each(function (key, value) {
                        if (response == null) {
                            loadData();                          
                        } else {
                            html += Mustache.render(template, {
                                Id: value.Id,
                                Name: value.Name,
                                Price: value.Price,
                                Status: value.Status == true ? "<span class=\"label label-success\">Stocking</span>" : "<span class=\"label label-danger\">Out of stock</span>"
                            });
                        }                      
                    });
                    $('#tbody').html(html);
                    paging(response.totalRow, function () {
                        loadData();
                    });
                },
                error: function () {
                    console.log('Error in Operation');
                }
            });
        });

    }

    //Get data and display on page
    function loadData() {

        $.ajax({
            url: '/api/GetProductAPI',
            type: 'GET',
            data: {
                page: homeconfig.pageIndex,
                pageSize: homeconfig.pageSize
            },
            dataType: 'json',
            success: function (response) {
                var html = '';
                var template = $('#data-template').html();
                $(response.data).each(function (key, value) {

                    html += Mustache.render(template, {
                        Id: value.Id,
                        Name: value.Name,
                        Price: value.Price,
                        Status: value.Status == true ? "<span class=\"label label-success\">Stocking</span>" : "<span class=\"label label-danger\">Out of stock</span>"
                    });

                });
                $('#tbody').html(html);
                paging(response.totalRow, function () {
                    loadData();
                });
                replaceField();
            }
        });

    }

    function paging(totalRow, callback) {
        var totalPage = Math.ceil(totalRow / homeconfig.pageSize);
        $('#pagination').twbsPagination({
            totalPages: totalPage,
            visiblePages: 7,
            onPageClick: function (event, page) {
                homeconfig.pageIndex = page;
                setTimeout(callback, 200);
            }
        });
    }

    function replaceField() {
        $('#txtId').val('');
        $('#txtName').val('');
        $('#txtPrice').val('');
    }
}