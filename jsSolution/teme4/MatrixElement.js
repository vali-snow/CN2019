const Decimal = require('decimal');
class MatrixElement{

    //this.value should always be a decimal object
    constructor(value,row,column)
    {
        if(!(value instanceof Decimal))
        {
            throw "Not a decimal";
        }
        this.value = value;
        this.row = row;
        this.column = column;
    }
    setValue(value)
    {
        if(!(value instanceof Decimal))
        {
            throw "Not a decimal";
        }
        this.value = value;
    }
    getValue()
    {
        return this.value;
    }
}

module.exports = MatrixElement;