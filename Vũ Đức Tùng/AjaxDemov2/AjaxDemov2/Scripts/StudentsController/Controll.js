var StudentsContrller = function() {

    this.init = function () {
        loadData();
        registerEvent();
        setTimeout(function () { loadData(); }, 10000);

    }
    function registerEvent() {

        $('body').on('click', '#btnAddNew222', function (e) {
            e.preventDefault();
            
            $('#exampleModal').modal('show');
            
            
        });
        $('body').on('click', '#EditPartial', function (e) {
            e.preventDefault();
            
            var id = $(this).data('id');
            GetDetails(id);
            
            
        });
        $('body').on('click', '#Savechanges', function (e) {
            e.preventDefault();
            var id = $('#txtid').val();
            var Name = $('#txtName').val();
            var Local = $('#txtLocal').val();
            var StudentClass = $('#txtStudentClass').val();
            save(id,Name, Local, StudentClass);
        });
       
        $('body').on('click', '#Delete', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            DeleteStudent(id);
        });
    };
    function GetDetails(id) {
        $.ajax({
            url: '/Students/GetDetails',
            data: {
                ID: id
            },
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                
                if (response.status == true) {
                    var data = response.data;
                   
                    $('#txtid').val(data.ID);
                    $('#txtName').val(data.Name);
                    $('#txtLocal').val(data.Local);
                    $('#txtStudentClass').val(data.StudentClass);
                    $('#exampleModal').modal('show');
                }

            },
            error: function (err) {
                alert('error')
            }
        });
    };
    function DeleteStudent(id) {
        $.ajax({
            url: '/Students/Delete',
            data: {
                
                ID: id
            },
            type: 'POST',
            dataType: 'json',
            success: function (response) {
                alert('delete done');
                

                loadData();
            },
            error: function (err) {
                alert('error')
            }
        });
    };
    function loadData() {
        $(document).ready(function () {
            var html1 = '';
            var template = $('#data-template').html();
            $.ajax({
                url: '/Students/loadData',
                type: 'GET',
                dataType: 'json',
                success: function (response) {
                    if (response.status) {
                        $.each(response.data, function (i, item) {
                            html1 += Mustache.render(template, {
                                ID : item.ID,
                                Name: item.Name,
                                Local: item.Local,
                                studentclass: item.StudentClass
                            });
                            $('#exampleModal').modal('hide');
        
                        });
                        $('#tblData').html(html1);
                    }
                }

            })
        });
    }
    function save (id,Name, Local, StudentClass) {
        $.ajax({

            url: '/Students/save',
            data: {
                ID: id,
                Name: Name,
                Local: Local,
                StudentClass: StudentClass
            },
            type: 'POST',
            dataType: 'json',
            success: function (response) {
                alert('done');
                
                
                loadData();
            },
            error: function (err) {
                alert('error')
            }
        });

        
    }
   


    
}
