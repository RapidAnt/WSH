function calculate() {
    var forint = parseFloat($("#forint").val().toString().replace(',', '.')) || 0;
    var rate = parseFloat($("#rate").data('rate').toString().replace(',', '.')) || 0;
    var unit = parseFloat($("#unit").data('unit').toString().replace(',', '.')) || 0;

    var result = 0;

    if (rate != 0) {
        result = forint / rate * unit;
        console.log(result);
    }

    console.log(result);
    $("#result").html(result.toFixed(2));
}