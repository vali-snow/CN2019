const Decimal = require('decimal');

class Dense{

    constructor()
    {
        this.valueList = [];
    }
    addValue(value)
    {
        this.valueList.push(new Decimal(value));
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
        if(index < 0 && index >= this.valueList.length) throw "Index out of bounds";
        this.valueList[index] = new Decimal(value);
    }
}

module.exports = Dense;