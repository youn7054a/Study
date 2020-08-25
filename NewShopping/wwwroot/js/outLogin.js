
function testAPI() {
    FB.api('/me', { locale: 'tr_TR', fields: 'email,name' }, function (response) {
        console.log(response);
        console.log(response.email);
    });
}

function chkLogin() {

    FB.getLoginStatus(function (response) {
        if (response.status === 'connected') {
            // The user is logged in and has authenticated your
            // app, and response.authResponse supplies
            // the user's ID, a valid access token, a signed
            // request, and the time the access token
            // and signed request each expire.
            var uid = response.authResponse.userID;
            var email = response.authResponse.email;;
            var accessToken = response.authResponse.accessToken;
            document.getElementsByClassName("fb-login-button")[0].style.display = 'inline';
            console.log(email);

            var dataJSON = { "email": email }

            $.ajax({
                type: "POST",
                url: "@Url.Action("OutLogin", "Login")",
                data: JSON.stringify(dataJSON),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function () {
                },
                error: function () {
                }
            });

        } else if (response.status === 'not_authorized') {
            // The user hasn't authorized your application.  They
            // must click the Login button, or you must call FB.login
            // in response to a user gesture, to launch a login dialog.
            document.getElementsByClassName("fb-login-button")[0].style.display = 'inline';
            console.log(2);
        } else {
            document.getElementsByClassName("fb-login-button")[0].style.display = 'inline';
            console.log(3);
        }
    });
}

$(document).ready(function () {
    chkLogin();
});