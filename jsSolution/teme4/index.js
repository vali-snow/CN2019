const Decimal = require('decimal');
const MatrixElement = require('./MatrixElement');
const DenseVector = require('./DenseVector');
const SparseMatrix = require('./SparseMatrix');
const fs = require('fs');
const MatrixInstance = require('./MatrixInstance');

let matrice1 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice1.txt');
let matrice2 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice2.txt');
let matrice3 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice3.txt');
let matrice4 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice4.txt');
let matrice5 = new MatrixInstance('C:\\Users\\TudorIacobuta\\Desktop\\CN2019\\jsSolution\\teme4\\matrice5.txt');

matrice1.readFromFile();
matrice2.readFromFile();
matrice3.readFromFile();
matrice4.readFromFile();
matrice5.readFromFile();

console.log(matrice1.matrix.elements[0]);

