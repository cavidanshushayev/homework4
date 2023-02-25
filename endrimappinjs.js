let mebleg =1222;
let endrimlimebleg
if (mebleg < 100) {
    console.log("tebrikler siz 5% endrim qazandiniz");
    endrimlimebleg = mebleg - mebleg * 5 / 100;
    console.log("endrimden sonra odemeli oldugunuz mebleg:" + endrimlimebleg);
} else if (mebleg > 100 && mebleg < 1000) {
    console.log("tebrikler siz 8% endrim qazandiniz");
    endrimlimebleg = mebleg - mebleg * 8 / 100;
    console.log("endrimden sonra odemeli oldugunuz mebleg:" + endrimlimebleg);
} else {
    console.log("tebrikler siz 10% endrim qazandiniz");
    endrimlimebleg = mebleg - mebleg * 10 / 100;
    console.log("endrimden sonra odemeli oldugunuz mebleg:" + endrimlimebleg);

}