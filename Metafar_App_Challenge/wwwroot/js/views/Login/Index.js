const getSignInData = () => {
    let data = {
        'name': $('input#password-SignIn').val(),
        'password': $('input#password-SignIn').val(),
    }
    return data;
}

const getRegisterData = () => {
    let data = {
        'name': $('input#password-Register').val(),
        'password': $('input#password-Register').val(),
    }
    return data;
}

$('#SignIn-btn').on('click', function (x) {
    const data = getSignInData();
    let url = `/Login/SignIn?${$.param(data)}`;

    $.ajax({
        url: url,
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (result) {
            if (result == "") {
                var element = document.getElementById("warning-Login")
                element.classList.remove("invisible");
            }
        },
    })
});

$('#Register-btn').on('click', function (x) {
    const data = getRegisterData();
    let url = `/Login/Register?${$.param(data)}`;

    $.ajax({
        url: url,
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (result) {
            if (result.repeated) {
                var element = document.getElementById("warning-Register")
                element.classList.remove("invisible");
            }
            else {
                var element = document.getElementById("success-Register")
                element.classList.remove("invisible");
            }
            
        },
    })
});