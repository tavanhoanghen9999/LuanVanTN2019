﻿
//get detail product
function getProductById(id, callback) {
    $.ajax({
        type: "get",
        url: linkserver + "productuser/GetproductbyId?id=" + id,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            callback(err);
        },
        success: function (data) {
            callback(data);
        }
    });
}
function bindingPrById(data) {
    var pr = data.data;
    if (data.success) {
        $("#name-prd").text(pr.product.prname);
        $("#note-prd").text(pr.product.note);
        $("#price-pr").text(formatNumber(pr.product.price) + " đ");
        $("#old-price").text(formatNumber(pr.product.oldprice) + " đ");

        var x = parseInt(pr.product.price);
        var y = parseInt(pr.product.oldprice);
        var dsc = (x - y) / y * 100;
        var temp = Math.round(parseFloat(dsc) * 100) / 100;
        $("#t-price-dc").text("(" + temp + "%)");
        $("#img-main-prd").css('background-image', 'url(' + serverfile + pr.product.image + ')');
        getSamePrd(pr.product.lineprid, bindingSamePr);
        if (pr.images.length > 0) {
            for (var i in pr.images) {
                $(".form-more-img").append('<div class="k bd-img-more">' +
                    '<div class= "k img-more" onclick="changePictire(this)" style=" background-image:url(' + serverfile + pr.images[i].image +')"></div >' +
                    '</div >');
            }
        }
    }
    else {
        bootbox.alert("Có lỗi xảy ra xin vui lòng thử lại");
    }
}

//get same products
function getSamePrd(lnid, callback) {
    $.ajax({
        type: "get",
        url: linkserver + "productuser/GetPrByLn?lnid=" + lnid,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            callback(err);
        },
        success: function (data) {
            callback(data);
        }
    });
}
//binding same product
function bindingSamePr(data) {
    if (data.success) {
        for (var i = 1; i < data.data.length; i++) {
            var item = data.data[i];
            var x = parseInt(item.price);
            var y = parseInt(item.oldprice);
            var dsc = (x - y) / y * 100;
            var temp = Math.round(parseFloat(dsc) * 100) / 100;

            $(".bd-list-pr").append('<a href="/product/product?prid=' + item.prid + '"><div class="k bd-id-pr">' +
                '<div class= "k f-it-more" >' +
                '<div class="k img-pr-more" style="background-image:url(' + serverfile + item.image + ')"></div>' +
                '<span class="k t-name-pr-more">' + item.prname + '</span>' +
               
                '<span class="k t-price-more">' + formatNumber(item.price) + ' đ</span>' +
                '<span class="k t-prds-more">' + formatNumber(item.oldprice) + ' đ</span>' +
                '<span class="k t-prds-dc">' + temp + '%</span>' +
                '</div >' +
                '</div ></a>');
        }
    }
    else {
        bootbox.alert("Có lỗi xảy ra xin vui lòng thử lại");
    }
}


//get evaluate 
function getEvaluate(prid) {
    $.ajax({
        type: "get",
        url: linkserver + "evaluate/getEvaByPr?prid=" + prid,
        data: null,
        dataType: 'json',
        contentType: "application/json",
        error: function (err) {
            bootbox.alert("Có lỗi xảy ra vui lòng thử lại");
        },
        success: function (data) {
            if (data.success) {
                for (var i = 0; i < data.data.everage
                    ; i++) {
                    $("#bd-evaluate").append('<i class="fa fa-star ic-star" aria-hidden="true"></i>');
                }
            }
            else {
                for (var j = 0; j < 5; j++) {
                    $("#bd-evaluate").append('<i class="fa fa-star ic-star" aria-hidden="true"></i>');
                }
            }
        }
    });
}
//change number 
function changeNumber(bool) {
    var numb = parseInt($("#numb").text());
    if (bool) {
        numb++;
        $("#numb").text(numb);
    }
    else {
        numb--;
        if (numb < 1) {
            numb = 1;
        }
        $("#numb").text(numb);
    }
}
getDayNextWeek();
//get time deliver//ngày giao dự kiến
function getDayNextWeek() {
    var today = new Date();
    var dd = String(today.getDate() + 7).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); //January is 0!
    var yyyy = today.getFullYear();
    //var sttoday = dd + '/' + mm + '/' + yyyy;
    $(".t-time").text("Dự kiến trong ngày " + dd + " tháng " + mm + " năm " + yyyy + "");
}

//add product to cart
function addPrToCarrt() {
    var model = { prid: prid, total: parseInt($("#numb").text()) };
    addToCart(model);
}
//change picture view
function changePictire(obj) {
    var idchr = obj.style.backgroundImage;
    var imgchildrent = document.getElementById("img-main-prd").style.backgroundImage;
    $(obj).css("background-image", imgchildrent);
    $("#img-main-prd").css("background-image", idchr);
}
