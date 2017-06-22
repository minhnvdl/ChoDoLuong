
//Convert /date(...)/ to datetime
function convertDatetime(input, fullDateTime, ampm, format) {
    if (format == null || format == "") {
        format = 'dmy';
    }
    if (input == null || input == "")
        return "";
    var time = "";
    var value = new Date(parseInt(input.replace(/(^.*\()|([+-].*$)/g, '')));
    var day = value.getDate() > 9 ? value.getDate() : "0" + value.getDate();
    var month = (value.getMonth() + 1) > 9 ? (value.getMonth() + 1) : "0" + (value.getMonth() + 1);
    var year = value.getFullYear();

    var gio = value.getHours();
    if (ampm) {
        var time = gio >= 12 ? 'PM' : 'AM';
        gio = gio % 12;
        gio = gio ? gio : 12;
    }
    var hour = gio > 9 ? gio : "0" + gio;
    var minute = value.getMinutes() > 9 ? value.getMinutes() : "0" + value.getMinutes();
    var second = value.getSeconds() > 9 ? value.getSeconds() : "0" + value.getSeconds();

    var result = "";
    if (format == "dmy") {
        result = day + "/" + month + "/" + year;
    } else if (format == "mdy") {
        result = month + "/" + day + "/" + year;
    } else {
        result = year + "/" + month + "/" + day;
    }



    if (fullDateTime) {
        if (ampm)
            return result + " " + hour + ":" + minute + ":" + second + " " + time;
        return result + " " + hour + ":" + minute + ":" + second;
    }
    return result;
}

//Show Money 000,000,000
function showMoney(input) {
    input += '';
    x = input.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1)) {
        x1 = x1.replace(rgx, '$1' + ',' + '$2');
    }
    return x1 + x2;
}


function prossessTopStart() {
    NProgress.settings.parent = '.content';
    NProgress.start();
}

function prossessModelStart() {
    NProgress.settings.parent = '.modal-body';
    NProgress.start();
}

function prossessCustomeStart(viewClass) {
    NProgress.settings.parent = '.' + viewClass;
    NProgress.start();
}

//Chuyen datetime ve yyyy-MM-dd
function formatDefaultSQLDate(value) {
    var ngay = value.getDate();
    if (ngay < 10) {
        ngay = '0' + ngay;
    }
    var thang = value.getMonth() + 1;
    if (thang < 10) {
        thang = '0' + thang;
    }
    var nam = value.getFullYear();

    return nam + '-' + thang + '-' + ngay;
}
// chuyen tu json to date type
function parseJsonDate(jsonDateString) {
    return new Date(parseInt(jsonDateString.replace('/Date(', '')));
}

function ConvertMoneyToNumber(value) {
    var Re = new RegExp("\\,", "g");
    value = value.replace(Re, "");
    return parseFloat(value);
}


function print(url) {
    console.log(url);
    var iframe = this._printIframe;
    if (!this._printIframe) {
        iframe = this._printIframe = document.createElement('iframe');
        document.body.appendChild(iframe);

        iframe.style.display = 'none';
        iframe.onload = function () {
            setTimeout(function () {
                iframe.focus();
                iframe.contentWindow.print();
            }, 1);
        };
    }

    iframe.src = url;
}


function getFields(input, field) {
    var output = [];
    for (var i = 0; i < input.length ; ++i)
        output.push(input[i][field]);
    return output;
}

function select2Focus() {
    $(this).closest('.select2').prev('select').select2('open');
}


function TruNgayThang(date1, date2) {
    var day1 = date1.getDate();
    var month1 = date1.getMonth() + 1;
    var year1 = date1.getFullYear();
    var hour1 = date1.getHours();
    var minute1 = date1.getMinutes();
    var second1 = date1.getSeconds();

    var day2 = date2.getDate();
    var month2 = date2.getMonth() + 1;
    var year2 = date2.getFullYear();
    var hour2 = date2.getHours();
    var minute2 = date2.getMinutes();
    var second2 = date2.getSeconds();

}
