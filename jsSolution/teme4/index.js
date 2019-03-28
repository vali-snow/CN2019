const Decimal = require('decimal.js');
const MatrixElement = require('./MatrixElement');
const DenseVector = require('./DenseVector');
const SparseMatrix = require('./SparseMatrix');
const fs = require('fs');
const MatrixInstance = require('./MatrixInstance');

let testMatrice = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matriceExemplu.txt');
//let matrice1 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice1.txt');
//let matrice2 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice2.txt');
//let matrice3 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice3.txt');
// let matrice4 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice4.txt');
// let matrice5 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice5.txt');

testMatrice.readFromFile();
//matrice1.readFromFile();
// matrice2.readFromFile();
// matrice3.readFromFile();
// matrice4.readFromFile();
// matrice5.readFromFile();


function calculateXkplus1(oldVector,matrix,omega,vector)
{

    let newVector = new DenseVector();
    let n = Object.keys(matrix.elements).length;
    let i = 0;
    while(i !== n)
    {
        let sum1 = new Decimal(0);
        let sum2 = new Decimal(0);
        let mainDiagonal = matrix.elements[i].filter( elem => elem.row === i);
        let aii = mainDiagonal[0].getValue();
        let bi = vector.getValue(i);
        let oldVectorXki = oldVector.getValue(i);

        for(let j = 0; j < n; j++)
        {
            let aij = matrix.elements[j].filter( elem => elem.row === i);
            let oldVectorXkj = oldVector.getValue(j);
            
            if(j < i)
            {
                let newVectorXkj = newVector.getValue(j);
                if(aij.length)
                {   
                    sum1 = sum1.add(newVectorXkj.mul(aij[0].getValue()));
                }
                else
                {
                    sum1 = sum1.add(new Decimal(0));
                }
                
            }
            else if(j > i)
            {
                if(aij.length)
                {   
                    sum2 = sum2.add(oldVectorXkj.mul(aij[0].getValue()));
                }
                else
                {
                    sum2 = sum2.add(new Decimal(0));
                }
            }
        }

        newVector.addValue(omega.mul(bi.sub(sum1).sub(sum2)).div(aii).add(oldVectorXki));
        i++;
    }
    return newVector;
}
function calcultateNorm(v1,v2)
{
    let n = v1.getCount();
    let sum = new Decimal(0);
    let e = new DenseVector();
    for(let i = 0; i < n; i++)
    {
        e.addValue(v1.getValue(i).sub(v2.getValue(i)).pow(2));
    }
    for(let i = 0; i < n; i++)
    {
        sum = sum.add(e.getValue(i));
    }

    return sum.sqrt();

}
function findXaproximation(matrix,vector,omega,epsilon,kmax = 10000)
{
    let xc = new DenseVector();
    let xp;
    for(let i=0;i<vector.getCount();i++)
    {
        xc.addValue(new Decimal(0));
    }
    let k = 0;
    let deltaX;
    do {
        xp = xc;
        xc = calculateXkplus1(xp,matrix,omega,vector);
        deltaX = calcultateNorm(xc,xp);
        k++;
    } while (deltaX.gte(epsilon) && k <= kmax && deltaX.lte(new Decimal(10).pow(8)));
    console.log(k);
    return xc;
}
console.log(findXaproximation(testMatrice.matrix,testMatrice.vector,new Decimal(0.8),new Decimal(10).pow(-10)))




