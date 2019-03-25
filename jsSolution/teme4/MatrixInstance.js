const Decimal = require('decimal');
//const MatrixElement = require('./MatrixElement');
const DenseVector = require('./DenseVector');
const SparseMatrix = require('./SparseMatrix');
const fs = require('fs');
const path = require('path');


class MatrixInstance{

    constructor(filepath)
    {
        if(!path.isAbsolute(filepath))
        {
            throw "Not absolute path";
        }
        this.filepath = filepath;
        this.matrix = new SparseMatrix();
        this.vector = new DenseVector();
    }
    readFromFile()
    {
        
        var contents = fs.readFileSync(this.filepath, 'utf8');
        let linesRead = contents.split(/\r?\n/);
        let i = 2;
        while(linesRead[i] !== "")
        {
            let line = linesRead[i].split(",");
            //console.log(line[0],line[1],line[2]);
            let value = new Decimal(line[0]);
            let row = parseInt(line[1]);
            let column = parseInt(line[2]);
            if(row === column && value.toNumber() === 0)
            {
                throw "Element nenul pe diagonala principala";
            }
            this.matrix.addValue(value,row,column);
            i++;
        }
        i++;
        while(linesRead[i] !== "")
        {
            let value = new Decimal(linesRead[i]);
            this.vector.addValue(value);
            i++;
        }

        for(let j = 0; j < this.matrix.elements.length; j++)
        {
            this.matrix.elements[j].sort((a,b) => a.row - b.row)
        }
    }
}

module.exports = MatrixInstance;