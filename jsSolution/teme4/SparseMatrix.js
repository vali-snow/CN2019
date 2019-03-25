const Decimal = require('decimal');
const MatrixElement = require('./MatrixElement');

class SparseMatrix{

    constructor() {
        
        this.elements = {};
    }
    addValue(value, row, column)
    {
        if(!(value instanceof Decimal))
        {
            throw "Not a decimal";
        }
        if(column in this.elements)
        {
            let columnList = this.elements[column];
            let matrixElem = columnList.filter( (elem) => elem.row === row);
            if(matrixElem.length !== 0)
            {
                matrixElem[0].setValue(matrixElem[0].getValue().add(value));
            }
            else
            {
                this.elements[column].push(new MatrixElement(value,row,column));
            }
        }
        else
        {
            this.elements[column] = [];
            this.elements[column].push(new MatrixElement(value,row,column));
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