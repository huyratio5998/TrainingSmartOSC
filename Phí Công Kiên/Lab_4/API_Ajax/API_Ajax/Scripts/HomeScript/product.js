//var homeconfig = {
//    pageSize: 3 
//}

var productController = function () {

    this.Init = function () {
        loadData();
        registerEvent();
    }

    function registerEvent() {
        
       /* 
        $('body').on('click', '#createProduct', function (e) {
            e.preventDefault();

            var product = {};
            product.Name = $('#productName').val();
            product.Price = parseInt($('#productPrice').val());
            //product.Status = $('#productStatus').is(":checked");

            $.post(
                '/api/ProductAPI',
                product,
                function () {
                    alert('Create data successful!');
                    loadData();
                    reload();
                },
                "json"
            );
        })

        function reload() {
            $('#productName').val('');
            $('#productPrice').val('');
        } 
        */
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
                error: function (xhr, textStatus, errorThrown) {
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
            var id = $('#txtId').val();
            deleteProduct(id);
        });

        function deleteProduct(id) {
            $.ajax({
                url: '/api/DeleteAPI',
                type: 'POST',
                dataType: 'json',
                data: { id: id },
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
    }

    //Get data and display on page
    function loadData() {
        
        $.ajax({
            url: '/api/ProductAPI',
            type: 'GET',
            //data: {
            //    page: 1,
            //    pageSize: homeconfig.pageSize
            //},
            dataType: 'json',
            success: function (data) {
                var html = '';
                var template = $('#data-template').html();
                $(data).each(function (key, value) {

                    html += Mustache.render(template, {
                        Id: value.Id,
                        Name: value.Name,
                        Price: value.Price,
                        Status: value.Status == true ? "<span class=\"label label-success\">Stocking</span>" : "<span class=\"label label-danger\">Out of stock</span>"
                    });
                    //$('table.table tbody').
                    //    append('<tr><td>' +
                    //        value.Name + '</td><td>' +
                    //        value.Price + '</td><td>' +
                    //        status + '</td><td class="text-center"><input type="radio"/></td></tr>');              
                });
                $('#tbody').html(html);
                reloadField();
                //paging(data.totalRow, function () {
                //    loadData();
                //});
            }
        });

        
    }

    function reloadField() {
        $('#txtId').val('');
        $('#txtName').val('');
        $('#txtPrice').val('');
    }

    //function paging(totalRow, callBack) {
    //    var totalPage = Math.ceil(totalRow / homeconfig.pageSize);
    //    $('#pagination').twbsPagination({
    //        totalPages: totalPage,
    //        visiblePages: 10,
    //        onPageClick: function (event, page) {
    //            loadData();
    //        }
    //    });
    //}
    
}