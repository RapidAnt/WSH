$(document).ready(function () {
    $('#currencyTable').dataTable({
        "bPaginate": false,
        "bFilter": false,
        "bInfo": false
    });
    $('.dataTables_length').addClass('bs-select');

    saveRateshandler();
});

function saveRateshandler() {
    $('#currencyTable').on('click', '#save-currency', function () {
        var element = $(this);

        element.prop('disabled', true);

        var ajaxObj = {
            Currency: $(this).data('currency'),
            Unit: $(this).data('unit'),
            CurrentRate: $(this).data('currentrate'),
            Comment: element.closest("tr").find("#comment").val()
        };

        $.post(page_urls.SaveRate, ajaxObj,
            function (res) {
                if (res) {
                    // Show notification about success
                    $(element).text("Saved");
                    $(element).removeClass("btn-primary");
                    $(element).addClass("btn-success");
                } else {
                    // Show notification about error
                    $(element).text("Error");
                    $(element).removeClass("btn-primary");
                    $(element).addClass("btn-warning");
                }
            }
        );
    });
}