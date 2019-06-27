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
             changeData(userName, passWord, fullName, genDer);
        });
    }

    //function saveData() {
    //    $.ajax({
    //        url: 'Home/takeData',
    //        type: 'POST',
    //        success : alert('Regestier success !')
    //    })
    //}

    function changeData(userName, passWord, fullName, genDer) {

        var user = {
            UserName : userName,
            Password : passWord,
            FullName : fullName,
            Gender : genDer
        }

        $.ajax({
            url: '/Home/takeData',
            type: 'POST',
            dataType: 'json',
            data: {
                strUser: JSON.stringify(user)
            },
            success: function (re) {
                if (re!=null) {
                    alert('Register Success !')
                    console.log(re.data.UserName);
                    var str = "<tr><td>" + re.data.UserName + "</td><td>" + re.data.Password + "</td><td>" + re.data.FullName +"</td><td>" + re.data.Gender + "</td></tr>";
                    $('#showUser').append(str);
                }
            }
        });
    }
}