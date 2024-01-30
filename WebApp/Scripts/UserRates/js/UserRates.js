$(document).ready(function () {
    $('#savedRatesTable').dataTable({
        "bPaginate": false,
        "bFilter": false,
        "bInfo": false
    });
    $('.dataTables_length').addClass('bs-select');

    DeleteSavedRatesHandler();
    UpdateSavedRatesHandler();
});

function DeleteSavedRatesHandler() {
    $('#savedRatesTable').on('click', '#delete-saved-rate', function () {
        var element = $(this);

        element.prop('disabled', true);

        var ajaxObj = {
            rateId: $(this).data('id'),
        };

        $.post(page_urls.DeleteRate, ajaxObj,
            function (res) {
                if (res) {
                    // Would be better to Show notification about success and refresh with ajax or doom
                    window.location.href = res;
                } else {
                    // Would be better to Show notification about error and refresh with ajax or doom
                    window.location.href = res;
                }
            }
        );
    });
}

function UpdateSavedRatesHandler() {
    $('#savedRatesTable').on('click', '#update-saved-rate', function () {
        var element = $(this);

        element.prop('disabled', true);

        var ajaxObj = {
            Id: $(this).data('id'),
            Comment: element.closest("tr").find("#comment").val()
        };

        console.log(ajaxObj);

        $.post(page_urls.UpdateRateComment, ajaxObj,
            function (res) {
                if (res) {
                    $(element).text("Updated");
                    $(element).removeClass("btn-primary");
                    $(element).addClass("btn-success");

                    element.prop('disabled', false);
                } else {
                    $(element).text("Error");
                    $(element).removeClass("btn-primary");
                    $(element).addClass("btn-warning");
                }
            }
        );
    });
}