


var UserController = function () {

    this.intialize = function () {
       
        registerEvent();
    }

    function registerEvent() {

        $('body').on('click', '#Register1', function (e) {
            e.preventDefault();
            var userName = $('#txtUserName').val();
            var passWord = $('#txtPassword').val();
            var fullName = $('#txtFullName').val();
            var genDer = $('#txtGender').val();
            saveData(userName, passWord, fullName, genDer);

        });
    }


    function saveData(userName, passWord, fullName, genDer) {

        var user = {
            UserName : userName,
            Password : passWord,
            FullName : fullName,
            Gender : genDer
        }

        $.ajax({
            url: '/Home/Block3',
            type: 'POST',
            dataType: 'json',
            data: {
                strUser: JSON.stringify(user)
            },
            success: function (response) {
                if (response.status == true) {
                    alert('Register Success !')
                    $('#ShowUser').append("<tr>"
                        + "<td>" + userName + "</td>" +
                        +"<td>" + passWord + "</td>" +
                        +"<td>" + fullName + "</td>" +
                        +"<td>" + genDer + "</td>" +
                        "</tr>")
                }
            }
        });
    }
}