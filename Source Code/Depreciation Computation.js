Reducing Method Depreciation Calculator

function reducing() {
var year1depn = document.reducingbalance.originalcost.value * (document.reducingbalance.annual.value/100);
var year1depn = year1depn.toFixed(2);
document.reducingbalance.year1depn.value=year1depn;
var year1value = document.reducingbalance.originalcost.value - document.reducingbalance.year1depn.value;
var year1value = year1value.toFixed(2);
document.reducingbalance.year1value.value=year1value;
var year2depn = document.reducingbalance.year1value.value * (document.reducingbalance.annual.value/100);
var year2depn = year2depn.toFixed(2);
document.reducingbalance.year2depn.value=year2depn;
var year2value = document.reducingbalance.year1value.value - document.reducingbalance.year2depn.value;
var year2value = year2value.toFixed(2);
document.reducingbalance.year2value.value=year2value;
var year3depn = document.reducingbalance.year2value.value * (document.reducingbalance.annual.value/100);
var year3depn = year3depn.toFixed(2);
document.reducingbalance.year3depn.value=year3depn;
var year3value = document.reducingbalance.year2value.value - document.reducingbalance.year3depn.value;
var year3value = year3value.toFixed(2);
document.reducingbalance.year3value.value=year3value;
var year4depn = document.reducingbalance.year3value.value * (document.reducingbalance.annual.value/100);
var year4depn = year4depn.toFixed(2);
document.reducingbalance.year4depn.value=year4depn;
var year4value = document.reducingbalance.year3value.value - document.reducingbalance.year4depn.value;
var year4value = year4value.toFixed(2);
document.reducingbalance.year4value.value=year4value;
var year5depn = document.reducingbalance.year4value.value * (document.reducingbalance.annual.value/100);
var year5depn = year5depn.toFixed(2);
document.reducingbalance.year5depn.value=year5depn;
var year5value = document.reducingbalance.year4value.value - document.reducingbalance.year5depn.value;
var year5value = year5value.toFixed(2);
document.reducingbalance.year5value.value=year5value;
}


Straight Line Depreciation Calculator

function straight() {
var depreciation = document.straightline.historicalcost.value / document.straightline.years.value;
var depreciation = depreciation.toFixed(2);
document.straightline.depreciation.value=depreciation;
var monthlydepreciation = document.straightline.depreciation.value / 12;
var monthlydepreciation = monthlydepreciation.toFixed(2);
document.straightline.monthlydepreciation.value=monthlydepreciation;
var months = document.straightline.years.value * 12;
var months = months.toFixed(0);
document.straightline.months.value=months+" months";
}
// -->