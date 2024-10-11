$(document).ready(function () {
    // BlockUI örneği
    $.blockUI({ message: '<h1>Processing...</h1>' });

    // 3 saniye sonra bloklamayı kaldır
    setTimeout($.unblockUI, 3000);
});
