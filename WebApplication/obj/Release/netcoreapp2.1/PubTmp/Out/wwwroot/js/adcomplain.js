﻿$(document).ready(function () {
    //var bol = checkTokenServerAd();
});
var bool = true;
var usid = -1;
var formdata = new FormData();
var formdataUd = new FormData();
var sex = -1;
var page = 0;
var role = 1;//admin
getComplain(bindingComplain, true);
//get event
function getComplain(callback, bol) {
    $.ajax({
        type: "get",
        url: linkserver + "Complain/GetAllgetComplain?page=" + page + "&pagesize=" + pagesize,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("error");
        },
        success: function (data) {
            if (data.success) {
                callback(data, bol);
            }
            else {
                bootbox.alert("error");
            }
        }
    });
}

    function bindingComplain(data, bol) {
    if (data != null) {
        if (bol) {//not lazyload
            $(".bd-inf-complain").remove();
        }
        for (var complain = 0; complain < data.length; complain++) {
            var stt = complain + 1;
            $('.bd-body-us').append('<div class="k body-complain bd-inf-complain">' +
                '<span class= "k note-tius" style = "width:5%;" >' + stt + '</span >' +
               
                '<span class="k note-tius" style="width:20%;">' + data[complain].title + '</span>' +
                '<span class="k note-tius" style="width:20%;">' + data[complain].content + '</span>' +
                '<span class="k note-tius" style="width:5%;">' + data[complain].phone + '</span>' +
                '<span class="k note-tius" style="width:20%;">' + data[complain].email + '</span>' +
                '<span class="k note-tius">' + formatDate(new Date(data[complain].createday)) + '</span>' +
                '<div class=" k f-edit">' +
                '<i class="fa fa-pencil-square-o font-ic" aria-hidden="true" onclick = showFormUd("' + data[complain].email + '") data-toggle="modal" data-target="#myModalcomplain"></i>' +
                '<i class="fa fa-trash-o font-ic" aria-hidden="true"></i>' +
                '</div>' +
                '</div >');
        }
        destroyLoading();
    }
}

function formatDate(date) {
    var hours = date.getHours();
    var minutes = date.getMinutes();
    var ampm = hours >= 12 ? 'pm' : 'am';
    hours = hours % 12;
    hours = hours ? hours : 12; // the hour '0' should be '12'
    minutes = minutes < 10 ? '0' + minutes : minutes;
    var strTime = hours + ':' + minutes + ' ' + ampm;
    var month = (date.getMonth() + 1) < 10 ? '0' + (date.getMonth() + 1) : (date.getMonth() + 1);
    var day = date.getDate() < 10 ? '0' + date.getDate() : date.getDate();
    return day + "/" + month + "/" + date.getFullYear();
}
$(document).ready(function () {
    $('#datepicker-us').datetimepicker({
        format: 'DD/MM/YYYY',
        extraFormats: false,
        stepping: 1,
        minDate: false,
        maxDate: false,
        useCurrent: true,
        collapse: true,
        locale: moment.locale(),
        defaultDate: false,
        disabledDates: false,
        enabledDates: false,
        icons: {
            time: 'glyphicon glyphicon-time',
            date: 'glyphicon glyphicon-calendar',
            up: 'glyphicon glyphicon-chevron-up',
            down: 'glyphicon glyphicon-chevron-down',
            previous: 'glyphicon glyphicon-chevron-left',
            next: 'glyphicon glyphicon-chevron-right',
            today: 'glyphicon glyphicon-screenshot',
            clear: 'glyphicon glyphicon-trash'
        },
        useStrict: false,
        sideBySide: false,
        daysOfWeekDisabled: [],
        calendarWeeks: false,
        viewMode: 'days',
        toolbarPlacement: 'default',
        showTodayButton: false,
        showClear: false,
        widgetPositioning: {
            horizontal: 'auto',
            vertical: 'auto'
        }
    });
});
function getImage() {
    $("#multi-file").click();
    $("#multi-file").change(function () {
        readImageUpload(this);
    });
}
function readImageUpload(input) {
    if (input.files && input.files[0]) {
        if (formdata.get("avatar") != null) {
            formdata.delete("avatar");
        }
        formdata.append("avatar", input.files[0]);
        var reader = new FileReader();
        reader.onload = function (e) {
            $("#img-main").css("background-image", "url(" + e.target.result + ")");
            $("#img-main").css("color", "rgba(51,51,51,0)");
        };
        reader.readAsDataURL(input.files[0]);
    }
    $("#multi-file").val("");
}
//insert complain
//function insertcomplain() {
//    try {
//        formdata.append("fullname", $('#inp-name').val());
//        formdata.append("roles", $('.value-roles-add').val());
//        formdata.append("email", $('#inp-email').val());
//        formdata.append("phone", $('#inp-phone').val());
//        formdata.append("address", $('#inp-addr').val());
//        formdata.append("birthday", $('#inp-bd').val());
//        formdata.append("password", md5($('#inp-pass').val()));
//        formdata.append("gender", sex);
//        var today = new Date();
//        var dd = String(today.getDate()).padStart(2, '0');
//        var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
//        var yyyy = today.getFullYear();
//        today = dd + '/' + mm + '/' + yyyy;
//        formdata.append("createday", today);
//        formdata.append("active", 1);
//        $.ajax({
//            type: "POST",
//            url: linkserver + 'complain/insertcomplain',
//            data: formdata,
//            processData: false,
//            contentType: false,
//            cache: false,
//            enctype: 'multipart/form-data',
//            success: function (data) {
//                if (data.data == "success") {
//                    bootbox.alert("Insert complain success!");
//                    page = 0;
//                    getcomplainByRole(role, page, true, bindingcomplainByRole);
//                    resetFormIs();
//                }
//                else {
//                    bootbox.alert("Error: ");
//                }
//            },
//            error: function (err) {
//                bootbox.alert("Error: " + err);
//            }
//        });
//    }
//    catch (err) {
//        //
//    }
//}

//remove checkbox
//function removeCheckbox(pos) {
//    sex = pos;
//    switch (pos) {
//        case 1:
//            document.getElementById("check-woman").checked = false;
//            document.getElementById("check-other").checked = false;
//            break;
//        case 2:
//            document.getElementById("check-man").checked = false;
//            document.getElementById("check-other").checked = false;
//            break;
//        default:
//            document.getElementById("check-man").checked = false;
//            document.getElementById("check-woman").checked = false;
//            break;
//    }
//}

//filter with role
//function changeRoles(obj) {
//    var value = obj.value;

//    if (value === '1') {
//        role = 1;
//        page = 0;
//        getcomplainByRole(role, page, true, bindingcomplainByRole);//get complain
//    }
//    else {
//        role = 2;
//        page = 0;
//        getcomplainByRole(role, page, true, bindingcomplainByRole);//get complain
//    }
//}
//filter complain by search box
//function filtercomplainBySearchBox(obj, callback) {
//    var data = { "roles": role, "filter": $(obj).val() };
//    $.ajax({
//        url: linkserver + 'complain/FiltercomplainBySearchBox',
//        type: 'POST',
//        dataType: 'json',
//        data: JSON.stringify(data),
//        async: false,
//        processData: false,
//        contentType: "application/json",
//        error: function (err) {
//            bootbox.alert({
//                message: "Error :" + err.message
//            });
//        },
//        success: function (data) {
//            if (data.success) {
//                callback(data.data, true);
//            }
//        }
//    });
//}

//reset form after inset complain
//function resetFormIs() {
//    document.getElementById("check-woman").checked = false;
//    document.getElementById("check-man").checked = false;
//    document.getElementById("check-other").checked = false;
//    $("#inp-name").val("");
//    $("#inp-email").val("");
//    $("#inp-addr").val("");
//    $("#inp-phone").val("");
//    $("#inp-pass").val("");
//    $("#img-main").css("background-image", "none");
//    $("#img-main").css("color", "rgb(51, 51, 51)");
//}
//var showp = true;

//format check show hide pass
//function showpass() {
//    var x = document.getElementById("inp-pass");
//    if (showp == true) {
//        x.type = "text";
//        showp = false;
//    }
//    else {
//        x.type = "password";
//        showp = true;

//    }
//}
//show hide pass update
//var showpud = true;
//function showpassUd() {
//    var x = document.getElementById("ed-pass-ud");
//    if (showpud == true) {
//        x.type = "text";
//        showpud = false;
//    }
//    else {
//        x.type = "password";
//        showpud = true;

//    }
//}
//showtap update complain 
//function showFormUd(emailus) {
//    formdataUd = new FormData();
//    callAjax(tp.post, "complain/getcomplainByEmail?email=" + emailus, null, bindingFormUpdate);
//}
//binding data insert
//function bindingFormUpdate(data) {
//    if (data) {
//        try {
//            $("#ud-fullname").val(data.fullname);
//            $("#ed-mail").text(data.email);
//            $("#ed-phone").val(data.phone);
//            $("#ed-address").val(data.address);
//            $("#ed-pass-ud").val(data.password);
//            $("#ed-birthday").val(formatDate(new Date(data.birthday)));
//            //document.getElementById('sl-gd-ud').getElementsByTagName('option')[data.gender - 1].selected = 'selected';
//            if (data.avatar != null) {
//                $("#image-mainud").css("background-image", 'url(' + serverfilecomplain + data.avatar + ')');
//                $("#image-mainud").css("color", "rgba(51,51,51,0)");
//            }
//            formdataUd.append("createday", formatDate(new Date(data.createday)).toString());
//            if (data.avatar) {
//                formdataUd.append("avatar", data.avatar.toString());
//            }
//            formdataUd.append("usid", data.usid);
//            console.log("dfasdfasdf")
//            formdataUd.append("email", data.email);
//        }
//        catch (err) {
//            //
//        }
//    }
//}

//function getImageUd() {
//    $("#multi-file").click();
//    $("#multi-file").change(function () {
//        readImageUploadUd(this);
//    });
//}
//function readImageUploadUd(input) {
//    if (input.files && input.files[0]) {
//        if (formdataUd.get("newavatar") != null) {
//            formdataUd.delete("newavatar");
//        }
//        formdataUd.append("newavatar", input.files[0]);
//        var reader = new FileReader();
//        reader.onload = function (e) {
//            $("#image-mainud").css("background-image", "url(" + e.target.result + ")");
//            $("#image-mainud").css("color", "rgba(51,51,51,0)");
//        };
//        reader.readAsDataURL(input.files[0]);
//    }
//    $("#multi-file-ud").val("");
//}
//function gotoUpdate() {

//    try {
//        if (!checkDataUd($('#ud-fullname').val(), $('#ed-pass').val())) {
//            bootbox.alert("Warning: complainname not empty ,password must be greater than 6  ");
//            return;
//        }
//        formdataUd.append("fullname", $('#ud-fullname').val());
//        formdataUd.append("roles", $('.value-roles-add').val());
//        formdataUd.append("email", $('#ed-mail').val());
//        formdataUd.append("phone", $('#ed-phone').val());
//        formdataUd.append("address", $('#ed-address').val());
//        formdataUd.append("birthday", $('#ed-birthday').val());
//        formdataUd.append("password", md5($('#ed-pass-ud').val()));
//        formdataUd.append("gender", parseInt($("#sl-gd-ud").val()));
//        formdataUd.append("usid", usid);


//        formdataUd.append("active", 1);
//        $.ajax({
//            type: "POST",
//            url: linkserver + 'complain/updatecomplain',
//            data: formdataUd,
//            processData: false,
//            contentType: false,
//            cache: false,
//            enctype: 'multipart/form-data',
//            success: function (data) {
//                if (data.data == "success") {
//                    bootbox.alert("Update complain success!");
//                    page = 0;
//                    getcomplainByRole(role, page, true, bindingcomplainByRole);
//                    $('#myModalcomplain').modal('toggle');
//                }
//                else {
//                    bootbox.alert("Error: ");
//                }
//            },
//            error: function (err) {
//                bootbox.alert("Error: " + err);
//            }
//        });
//    }
//    catch (err) {
//        alert("error");
//    }
//}

// date picker update complain
//$(document).ready(function () {
//    $('#datepicker-ud-complain').datetimepicker({
//        format: 'DD/MM/YYYY',
//        extraFormats: false,
//        stepping: 1,
//        minDate: false,
//        maxDate: false,
//        useCurrent: true,
//        collapse: true,
//        locale: moment.locale(),
//        defaultDate: false,
//        disabledDates: false,
//        enabledDates: false,
//        icons: {
//            time: 'glyphicon glyphicon-time',
//            date: 'glyphicon glyphicon-calendar',
//            up: 'glyphicon glyphicon-chevron-up',
//            down: 'glyphicon glyphicon-chevron-down',
//            previous: 'glyphicon glyphicon-chevron-left',
//            next: 'glyphicon glyphicon-chevron-right',
//            today: 'glyphicon glyphicon-screenshot',
//            clear: 'glyphicon glyphicon-trash'
//        },
//        useStrict: false,
//        sideBySide: false,
//        daysOfWeekDisabled: [],
//        calendarWeeks: false,
//        viewMode: 'days',
//        toolbarPlacement: 'default',
//        showTodayButton: false,
//        showClear: false,
//        widgetPositioning: {
//            horizontal: 'auto',
//            vertical: 'auto'
//        }
//    });
//});
//check correct item 
//function checkDataUd(fname, pass) {
//    if (fname.trim(0).length > 0) {
//        return true;
//    }
//    if (pass.trim().length > 6) {
//        return true;
//    }
//    return false;
//}