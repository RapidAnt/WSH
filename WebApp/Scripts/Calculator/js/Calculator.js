function calculate() {
    var forint = parseFloat($("#forint").val().toString().replace(',', '.')) || 0;
    var rate = parseFloat($("#rate").data('rate').toString().replace(',', '.')) || 0;
    var unit = parseFloat($("#unit").data('unit').toString().replace(',', '.')) || 0;

    var result = 0;

    console.log("-- INPUTS--");
    console.log(forint);
    console.log(rate);
    console.log(unit);

    if (rate != 0) {
        console.log("-- CALC --");
        result = forint / rate * unit;
        console.log(result);
    }

    console.log(result);
    $("#result").html(result.toFixed(2));
}