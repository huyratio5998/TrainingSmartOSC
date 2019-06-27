
var StudentController = function () {

    this.initialize = function () {
        setTimeout(function () { loadData(); }, 1000*60*10);
        //loadData();
        registerEvents();
    }
      
    function registerEvents() {

        $('body').on('click', '#noname', function (e) {
            e.preventDefault();
            loadData();
        });
        
    }

    function loadData() {
        $.ajax({
            url: "/Home/Student",
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                var template = $('#data-template').html();
                var render = "";
                $.each(response.data, function (i, item) {
                    render += Mustache.render(template,
                        {
                            Name: item.Name,
                            Age: item.Age,
                            Gender: item.Gender,
                            Email: item.Email,
                            Phone: item.Phone
                        });
                  
                });

                $('#tblData').html(render);
            }
        });
     
    }
    function create() {

    }
}