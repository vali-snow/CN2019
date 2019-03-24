const Decimal = require('decimal');
const MatrixElement = require('./MatrixElement');

class SparseMatrix{

    constructor() {
        
        this.elements = {};
    }
    addValue(value, row, column)
    {
        if(row in this.elements)
        {
            let rowList = this.elements[row];
            let matrixElem = rowList.filter( (elem) => elem.column === column);
            if(matrixElem.length !== 0)
            {
                matrixElem[0].setValue(value);
            }
            else
            {
                this.elements[row].push(new MatrixElement(value,row,column));
            }
        }
        else
        {
            this.elements[row] = [];
        }
        
    }
    getMatrixValue(row,column)
    {
        let rowList = this.elements[row];
        let matrixElem = rowList.filter( (elem) => elem.column === column);
        if(matrixElem.length !== 0)
        {
            return matrixElem[0].getValue();
        }
    }
}

module.exports = SparseMatrix;