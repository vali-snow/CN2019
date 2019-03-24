const Decimal = require('decimal');
class MatrixElement{

    constructor(value,row,column)
    {
        this.value = new Decimal(value);
        this.row = row;
        this.column = column;
    }
    setValue(value)
    {
        delete this.value;
        this.value = new Decimal(value);
    }
    setResult(result)
    {
        delete this.value;
        this.value = result;
    }
    getValue()
    {
        return this.value;
    }
}

module.exports = MatrixElement;