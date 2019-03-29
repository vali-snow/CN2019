var decimal = require('decimal.js');
console.log(decimal);

let t = new decimal(21);
if(t.sqrt() instanceof decimal)
{
    console.log(t.sqrt());
}
