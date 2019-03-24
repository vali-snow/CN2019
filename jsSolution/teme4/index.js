const Decimal = require('decimal');
const MatrixElement = require('./MatrixElement');
const DenseVector = require('./DenseVector');
const SparseMatrix = require('./SparseMatrix');
const fs = require('fs');

var contents = fs.readFileSync('matrice1.txt', 'utf8');
//console.log(contents);