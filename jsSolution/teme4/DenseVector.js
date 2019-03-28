const Decimal = require('decimal.js');

class DenseVector{

    constructor()
    {
        this.valueList = [];
    }
    addValue(value)
    {
        if(!(value instanceof Decimal))
        {
            throw "Not a decimal";
        }
        this.valueList.push(value);
    }
    getCount()
    {
        return this.valueList.length;
    }
    getValue(index)
    {
        if(index < 0 && index >= this.valueList.length) throw "Index out of bounds";
        return this.valueList[index];
    }
    getSetValue(index,value)
    {
        if(!(value instanceof Decimal))
        {
            throw "Not a decimal";
        }
        if(index < 0 && index >= this.valueList.length) throw "Index out of bounds";
        this.valueList[index] = value;
    }
}

module.exports = DenseVector;