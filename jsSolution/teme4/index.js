const Decimal = require('decimal.js');
const MatrixElement = require('./MatrixElement');
const DenseVector = require('./DenseVector');
const SparseMatrix = require('./SparseMatrix');
const fs = require('fs');
const MatrixInstance = require('./MatrixInstance');

//let testMatrice = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matriceExemplu.txt');
let matrice1 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice1.txt');
//let matrice2 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice2.txt');
//let matrice3 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice3.txt');
// let matrice4 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice4.txt');
// let matrice5 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice5.txt');

//testMatrice.readFromFile();
matrice1.readFromFile();
// matrice2.readFromFile();
// matrice3.readFromFile();
// matrice4.readFromFile();
// matrice5.readFromFile();


function calculateXkplus1(oldVector,Amatrix,Bvector,omega)
{

    let newVector = new DenseVector();

    let n = Object.keys(Amatrix.elements).length;

    let i = 0;
    while(i !== n)
    {   
        //Sumele din formula
        let sum1 = new Decimal(0);
        let sum2 = new Decimal(0);
        let mainDiagonal = Amatrix.elements[i].filter( elem => elem.row === i);
        let aii = mainDiagonal[0].getValue();

        let bi = Bvector.getValue(i);
        let oldVectorXki = oldVector.getValue(i);
        
        //Calculate sums
        for(let j = 0; j < n; j++)
        {
            let aij = Amatrix.elements[j].filter( elem => elem.row === i);
            
            let oldVectorXkj = oldVector.getValue(j);
            if(j < i)
            {
                //Suma pana i-1
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
            else
            {
                //Suma de la i pana la n-1
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
        let diff = bi.sub(sum1).sub(sum2)
        let raportValue = omega.mul(diff).div(aii)
        newVector.addValue(oldVectorXki.add(raportValue));
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
function scalarMultipication(matrix,vector)
{
    let n = Object.keys(matrix.elements).length;
    let resultVector = new DenseVector();
    for(let i = 0; i < n; i++)
    {   
        let sum = new Decimal(0);
        for(let j = 0; j < n; j++)
        {
            let xi = vector.getValue(j);
            let fromMatrix = matrix.elements[j].filter( elem => elem.row === i);
            let aij = fromMatrix[0];
            sum = sum.add(aij.mul(xi));
        }
        resultVector.addValue(sum);
    }
    return resultVector;
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
        xc = calculateXkplus1(xp,matrix,vector,omega);
        deltaX = calcultateNorm(xc,xp);
        k++;
    } while (deltaX.gte(epsilon) && k <= kmax && deltaX.lte(new Decimal(10).pow(8)));
    if(deltaX.lt(epsilon))
    {
        let solVector = scalarMultipication(matrix,xc);
        let testNorma = calcultateNorm(solVector,vector);
        if(testNorma.lt(epsilon))
        {
            console.log(testNorma.toString());
        }
        else
        {
            console.log("Not solution")
        }
    }
    else
    {
        console.log("Divergenta");
    }
}

findXaproximation(matrice1.matrix,matrice1.vector,new Decimal(0.8),new Decimal(10).pow(-16));
//console.log(matrice1.matrix.elements);



