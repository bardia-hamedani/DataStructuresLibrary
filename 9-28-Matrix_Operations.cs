using System;

namespace Data_Structure_And_Algorithms
{
    //public enum Matrix Data Structure Properties { a matrix is a mathematical object arising inamny physical problems,andmultidue of numerical and nonnumerical contexes from solutions of systems of equations to representation of graphs, but we are interested in studying ways to represnt matrices so that the operations to be perfomred on them can be carried out efficiently a general matrix consisits of m rows and n columns of numbers its very natural to store a matrixin a two dimensional array,>>>>a zero matrix is a matrix whose every entry is 0 square n*n matrices arise frequently several special cases of square matrices are of particular interest:(1)a diagonal matrix has aij =0 whenever i!=j(2)the n*n identity matrix In is a diagonal matrix with 1`s along the diagonal(3)a tridiagonal matrix T is one for which tij=0 if |i- j| nonzero entries appear only on the main diagonal imediately above the main diagnonal (ti,i+1 for i=1,...,n-1)or immediatelybelow the ain diagonal (ti+1,i for i=1,...,n-1)(4)an upper-triangular matrix U is one for which uij=0 if i>j all entries below the diagonal are zero(5)a lower-triangular matrix L is one for which lij=0 if i<j all entries above the diagonal are zero the product of two lower-triangular matrices is lower-triangular also the determinant of a lower-traingular or upper-triangular matrix is eqaul to product of its diaginal elelmnts also the inverse of a lower-triangular matrix if it exists is lower-triangular(6)a permutation matrix P has exactly one 1 in each row or cilumn and 0`s elsewhere its called permutaion matrix since we multiply a vector x by it its like permuting x if P is an n*n permutation matrix and A is an n*n matrix then PA can be obtained from A by permuting its rows and AP can be obtained from A by permuting its columns also the product of two pwemutation matrices is a permutation matrix also if P is a permutation matrix then P is invertible its inverse is P^T and P^T is a permutation matrix (7)a symmetric matrix A satisfies condition A=AT if A and B are symmetric n*n atrices then A+B and A-B also (AB)^T=B^T A^T and that AT*A is always a symmetric matrix,>>>>when all the elelmnts either above or below the main diagonal of a square matrix are zero then matrix is said to be traingular in a lower traingualr matrix a with n rows the maximum number of nonzero terms in row i is i + 1 hence ttal number of nonzero terms is Zigma (i=0 ... n - 1)i+1=n(n+1)/2 for large n it is worth while to save the sapce taken by the zero entries in upper traingle thenif matrix is stored in an array b[n(n+1)/2] with a[0][0] being tsored in b[0] then for a[i][j] address is B[(i(i-1)/2)+j],>>>>tridiagonal matrix all elelemnts other than those on the major digonal and on the diagonals immediately above and below this one are zero so for aij we have B[2i+j-2] };
    //public enum Matrix_Data_Structure_Inverse_Properties { we define inverse of an n*n matrix A to be the n*n matrix denoted A^(-1) such that A.A^(-1)=In=A^(-1).A,>>>>many nonzero n*n matrices dont have inverses a matrix without an inverse is called noninvertible or singular if a matrix has an inverse its called invertible or nonsingular if a matrix has an inverse its called invertibel or sonsingular matrix inverses when they exist are unique if A and B are nonsingular *n matrices then (BA)^(-1)=A^(-1).B^(-1),>>>>the inverse operations commutes with teh traspose operation (A^(-1))^T=(A^(T))^(-1),>>>>let A and B be n*n matrices such that AB=I then if A` can be obtained from A by adding row j into row i then inverse B` of A` can be obtained by subtracting column i from column j of B,>>>>let A be a nonsingular n*n matrix with complex entries then every entry of A^(-1) is real iff every entry of A is real ,>>>>if A is a nonsingular symetric n*n matrix then A^(-1) is symmetric if B is an arbitrary m*n marix then the m*m matrix given by product BAB^(T) is symmetric  };
    //public enum Matrix_Data_Structure_Column_Rank_Row_Rank_Properties { the column rank of a nonzero m*n matrix A is size of the largest set of linearly independent columns of A similarly the row rank of A is size of the largest set of linearly independent row of A,>>>>a fundemantal property of any matrix A is that its row rank always equala its column rank so taht we can simply refer to rank A the rank of an m*n matrix is an integer between 0 and min(m,n),>>>>an alternative but equivalent and more useful definition is taht the rank of a nonzero m*n matrix A is the smallest number r such taht there exist matrices B and C of respective sies m*r and r*n such that A=BC,>>>>a square n*n matrix has full rank if its rank is n ,>>>an m*n matrix has full column rank if its rank is n,>>>>a fundamenal property of ranks is given by folowing theorem Theorem:a squaer matrix has full rank iff its nonsingular,>>>>following theorem and its corollary relate notions of column rank and singularity to null vectors Theorem:a matrix A has full column rank iff it does not have a null vector Corollary:a square matrix A is singular iff it has a null vector,>>>> for any two compatible matrices A and B we have rank(AB)<=min(rank(A),rank(B)) where equality holds if either A or B is a nonsingular square matrix  };
    ////public enum Matrix_Data_Structure_Null_Vector_Properties { a null vector for a matrix Asi a nonzero vector x such that Ax=0 };
    //public enum Positive_Definite_Matrix_Data_Structure_Properties { an n*n matrix A is positive defiite if (x^(T))Ax>0 for all size-n vectors x!=0 e.g. identity matrix is positive definite ,>>>>matrices taht arise in applications are often positive-definite due to following theorem Theorem:for any matrix A with full column rank the matrix A^(T)*A is positive definite };
    public class Matrix<T> : ICloneable,IComparable where T : IComparable
    {
        public int columns, rows;
        public T[,] M;
        public bool IsNonSingular = false,HasFullColumnRank=false,HasNullVector=false,IsPositive_Definite=false;//baraye invert kardan tanzim
        public int CompareTo(object obj)
        {
            return 0;
            
        }
        public Matrix(T[,] init, int r, int c)
        {
            M = new T[r, c];
            for (int i = 0; i <= r - 1; i++)
                for (int j = 0; j <= c - 1; j++)
                    M[i, j] = init[i, j];
            rows = r;
            columns = c;
        }
        public Matrix(int r, int c)
        {
            M = new T[r, c];
            for (int i = 0; i <= r - 1; i++)
                for (int j = 0; j <= c - 1; j++)
                    M[i, j] = default(T);
            rows = r;
            columns = c;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
        //public enum Add_Algorithm_Properties { we define matrix addition so taht if A=(aij) and B=(bij) ae m*n matrices tehn their sum C=(cij)=A+B is th em*n matrix defiend by cij=aij+bij for i=1,...,m and j=1,...,n };
        public Matrix<double> Add(Matrix<double> AddingMatrix, Matrix<double> AddedMatrix)
        {
            Matrix<double> Result = new Matrix<double>(rows, columns);
            for (int i = 0; i <= AddingMatrix.rows - 1; i++)
                for (int j = 0; j <= AddingMatrix.columns - 1; j++)
                    Result.M[i,j] =AddingMatrix.M[i,j]+ AddedMatrix.M[i, j];
            return Result;
        }
        //public enum Subtract_Algorithm_Properties { its defined as the addition of the negative of a matrix A-B=A+(-B)};
        public Matrix<double> Subtract(Matrix<double> SubtractedMatrix, Matrix<double> SubtractingMatrix)
        {
            Matrix<double> Result = new Matrix<double>(rows, columns);
            for (int i = 0; i <= SubtractedMatrix.rows - 1; i++)
                for (int j = 0; j <= SubtractedMatrix.columns - 1; j++)
                    Result.M[i, j] = SubtractedMatrix.M[i,j] - SubtractingMatrix.M[i, j];
            return Result;
        }
        //public enum Multiply_Algorithm_Properties { we start with two matrices A and B that aer compatible  in the sense that number of columns of A equals the number of rows of B if A=(aij) ia an m*n matrix and B=(bjk) is an n*p matrix then their matrix product C=AB is the m*p matrix C=(cik) where cik=Zigma(j=1...n)aij*bjk for i=1,2,...,m and k=1,2,...,p,>>>>we have that ImA=AIn=A,A0=0,A(BC)=(AB)C,A(B+C)=AB+AC,(B+C)D=BD+CD ,AB!=BA ,>>>>to analyze its running time we have that to multiply n*n matrices procedure prforms n^3 multiplications and (n^2)(n-1) additions an so its running time is Theta(n^3) };
        public Matrix<double> Multiply(Matrix<double> MultipliedMatrix,Matrix<double> MultiplyingMatrix)//Tetha(n^3)
        {
            Matrix<double> Result = new Matrix<double>(MultipliedMatrix.rows, MultiplyingMatrix.columns);
            for (int i = 0; i <= MultipliedMatrix.rows - 1; i++)
                for (int j = 0; j <= MultiplyingMatrix.columns - 1; j++)
                {
                    Result.M[i, j] = 0;
                    for (int k = 0; k <= MultipliedMatrix.columns - 1; k++)
                        Result.M[i, j] += MultipliedMatrix.M[i,k] * MultiplyingMatrix.M[k, j];
                }
            return Result;
        }
        //public enum Transpose_ALgorithm_Properties { the transpose of a matrix A is matrix AT obtained by exchanging the rows and columns of A };
        public Matrix<T> Transpose(Matrix<T> matrix)
        {
            Matrix<T> Result = new Matrix<T>(matrix.columns, matrix.rows);
            for (int i = 0; i <= matrix.rows - 1; i++)
                for (int j = 0; j <= matrix.columns - 1; j++)
                    Result.M[j, i] = matrix.M[i,j];
            return Result;
        }
        public Matrix<double> Transpose(Matrix<double> matrix)
        {
            Matrix<double> Result = new Matrix<double>(matrix.columns, matrix.rows);
            for (int i = 0; i <= matrix.rows - 1; i++)
                for (int j = 0; j <= matrix.columns - 1; j++)
                    Result.M[j, i] = matrix.M[i, j];
            return Result;
        }
        public double column_sum = 0, column_sum_per_part = 0;
        //public enum Determinant_Algorithm_Properties { the determinant of an n*n matrix A can be defined recursively in terms of its minors by :det(A)={ a11 if n=1,Zigma(j=1...n)((-1)^(1+j)aij*det(A[1j]) if n>1 } ,>>>>the term ((-1)^(i+j))*det(A[ij]) is known as the coactor of element aij,>>>>the following theorems express fundamental properties of the determinant Theorem(Determinant properties):the determinant of a square matrix A has following properties:(1)if any row or any column of A is zero then det(A)=0 (2)the determinant of A is multiplied by Lambda if the entries of any row(or any one column) of A are all multiplied by Lambda (3)the determinant of A is unchanged if the entries in one row (respectively column) are added to those in another row (respectively column) (4)the determinant of A equals the determinanat of A^(T) (5_ the dtermiannat of A is multiplied by -1 if any two rows (respectively columns) are exchanged also for any square matrices A and B we have det(AB)=det(A)*det(B) Theorem:an n*n matrix A is singular iff det(A)=0 };
        public double Determinant(Matrix<double> A)
        {
            if (A.rows == 1 && A.columns == 1)
                return  A.M[0,0];
            else
            {
                for (int j = 0; j <= A.columns - 1; j++)
                {
                    Matrix<double> Result = new Matrix<double>(A.rows - 1, A.columns - 1);
                    Result = Result.Matrix_Minor(A, 0, j);
                    column_sum_per_part += (double)Math.Pow(-1, j) * A.M[0, j] * this.Determinant(Result);
                    if (columns == A.columns)
                    {
                        column_sum += column_sum_per_part;
                        column_sum_per_part = 0;
                    }
                }
                if (A.columns == columns)
                    return column_sum;
                else
                    return column_sum_per_part;
            }
        }
        //public enum Matrix_Minor_Algorithm_Properties { the ijth minor of an n*n matrix A for n>1 is the (n-1)*(n-1) matrix A[ij] obtained by deleting the ith row and jth column of A };
        public Matrix<T> Matrix_Minor(Matrix<T> matrix,int deleted_row,int deleted_column)
        {
            Matrix<T> Result = new Matrix<T>(matrix.rows-1, matrix.columns-1);
            for (int i = 0; i <= deleted_row-1; i++)
                for (int j = 0; j <= deleted_column-1; j++)
                    Result.M[i, j] = matrix.M[i, j];
            for (int i=0; i <= deleted_row-1; i++)
                for (int j = deleted_column+1; j <= matrix.columns-1 ; j++)
                    Result.M[i, j-1] = matrix.M[i, j];
            for (int i = deleted_row+1; i <= matrix.rows - 1; i++)
                for (int j = 0; j <= deleted_column - 1; j++)
                    Result.M[i-1, j] = matrix.M[i, j];
            for (int i = deleted_row + 1; i <= matrix.rows - 1; i++)
                for (int j = deleted_column + 1; j <= matrix.columns - 1 ; j++)
                    Result.M[i-1, j-1] = matrix.M[i, j];
            return Result;
        }
        //public enum Strassen_Multiply_Algorithm_Properties { this algorithm is an applicaion of divide and conquer design technique its a recursive approch that requires only 7 recurive mutlilications of n/2*n/2 Strassen method has four steps:(1)divide the input matrices A and B into n/2 * n/2 submatrices so that (<r,s>,<t,u>)=(<a,b>,<c,d>).(<e,f>,<g,h>) (2) using Theta(n^2) scalar additions and subtractions compute 14 matrices A1,B1,A2,B2,...,A7,B7 each of whic is n/2*n/2 (3)recursively compute the seven matrix products Pi=AiBi for i=1,..,7 (4)compute the desird submatrices r,s,t,u,of the result matrcic C by adding and/or subtracting various combinations of the Pi matrices using only Theta(n^2) scalar additions and subtractions we know that we have r=ae+bg,s=af+bh,t=ce+dg,u=cf+dh to detrmine the submatrices products  lets guess taht each matrix product Pi can be written in form Pi=AiBi=((alpha)i1*a+(alpha)i2*b+(alpha)i3*c+(alpha)i4*d).((beta)i1*e+(beta)i2*f+(beta)i3*g+(beta)i4*h)  where coefficients (alpha)ij ,(beta)ji are all drwan from the set {-1,0,1} here we can use this method recursively  without assuming commutativity of mutiplication since each product has all of the A submatrices on left and all of B submatrices on right  this property is essential since matrix multiplication isnt commutative we use 4*4 matrices to represent linear combinations of products of submatrices where each product combines one submatrix A with one sbmatrixof B then we observe that submatrix s can be computed as s=P1+P2 where P1 and P2 are computed using:P1=A1B1=a.(f-h)=af-ah,P2=A2B2=(a+b).h=ah+bh  the matrix t can be computed as t=P3+P4 where P3=A3B3=(c+d).e=ce+de and P4=A4B4=d.(g-e)=dg-de we define an essential term to be one of the eight terms appearing on right-hand side of one of equations making r,s,t,and u since until now we have used 4 products so we must use only 3 products to compute remainig two submatrices r and u whose essential terms are ae,bg,cf and dh we then mkae P5 in order to compute two essential terms at once:P5=A5B5=(a+b).(e+h)=ae+ah+de+dh here since P5 computes other than ae and sh  the additional ah and de terms  we need to cancel them  by using P4 and P2 but two other essential terms tehn appear:P5+P4-P2=ae+dh+dg-bh by adding an additional product:P6=A6B6=(b-d).(g+h)=bg+bh-dg-dh we obatin:r=P5+P4-P2+p6=ae+bg we can obtain u similarly from P5 by using P1 and P3 to move the inessential terms of P5 in a different direction :P5+P1-P3=ae+af-ce+dh by subtracting an addiotnal product:P7=A7B7=(a-c).(e+f)=ae+af-ce-cf we now obtain u=P5+P1-P3-P7=cf+dh now these 7 submatrix products P1,...,P7 can be used to compute the product C+AB,>>>>to analyze its running time we have that it reqiures only 7 recursive multiplications of (n/2)*(n/2) matrices and Theta(n^2) scalar addtions and subtractions yielding the recurrence T(n)=7T(n/2)+Theta(n^2)=Theta(n^(lg))=O(n^(2.81)) from practical point of view this algorithm is often not method of choice for matrix multiplication for four reasons:(1)constant factor hidden in runing itme of this algorithm is larger tahn conatant factor in naive Theta(n^3) method (2)when matrices are sparse methods tailored for sparse matrices are faster(3)thsi algorithm is not quite numerically stable as naive method (4)the submatrices formed at the levels of recursion consume space in practice fast matrix-mutiplication implementations for dense matrices use this algorithm for matrix sizes above a "crossover point" and they switch to the naive method when subproblem size reduces to below the crossover point the exact value of the crossover point is highly system dependent analyses conting operations but ignore effects from caches and pipelining have produced srossoverpoint as low as n=8 and n=12 for any given system ususallly crossover point is determiend by experiment  };
        public Matrix<double> Strassen_Multiply(Matrix<double> A, Matrix<double> B)//Tetha(n^lg7)=O(n^2.81)
        {
            Matrix<double> C = new Matrix<double>(A.rows, B.columns);
            Matrix<double> a = new Matrix<double>(A.rows / 2, A.columns / 2);
            Matrix<double> b = new Matrix<double>(A.rows / 2, A.columns / 2);
            Matrix<double> c = new Matrix<double>(A.rows / 2, A.columns / 2);
            Matrix<double> d = new Matrix<double>(A.rows / 2, A.columns / 2);
            Matrix<double> e = new Matrix<double>(B.rows / 2, B.columns / 2);
            Matrix<double> f = new Matrix<double>(B.rows / 2, B.columns / 2);
            Matrix<double> g = new Matrix<double>(B.rows / 2, B.columns / 2);
            Matrix<double> h = new Matrix<double>(B.rows / 2, B.columns / 2);
            Matrix<double> r = new Matrix<double>(A.rows / 2, A.columns / 2);
            Matrix<double> s = new Matrix<double>(A.rows / 2, A.columns / 2);
            Matrix<double> t = new Matrix<double>(A.rows / 2, A.columns / 2);
            Matrix<double> u = new Matrix<double>(A.rows / 2, A.columns / 2);
            for (int i = 0; i <= (A.rows / 2) - 1; i++)
                for (int j = 0; j <= (A.columns / 2) - 1; j++)
                {
                    a.M[i, j] = A.M[i, j];
                    e.M[i, j] = B.M[i, j];
                }
            for (int i = 0; i <= (A.rows / 2) - 1; i++)
                for (int j = (A.columns / 2); j <= A.columns - 1; j++)
                {
                    b.M[i, j - (A.columns / 2)] = A.M[i, j];
                    f.M[i, j - (A.columns / 2)] = B.M[i, j];
                }
            for (int i = (A.rows / 2); i <=A.rows - 1; i++)
                for (int j = 0; j <= (A.columns / 2) - 1; j++)
                {
                    c.M[i - (A.rows / 2), j] = A.M[i, j];
                    g.M[i - (A.rows / 2), j] = B.M[i, j];
                }
            for (int i = (A.rows / 2); i <= A.rows - 1; i++)
                for (int j = (A.columns / 2); j <= A.columns - 1; j++)
                {
                    d.M[i - (A.rows / 2), j - (A.columns / 2)] = A.M[i, j];
                    h.M[i - (A.rows / 2), j - (A.columns / 2)] = B.M[i, j];
                }
            Matrix<double> P1 = new Matrix<double>(A.rows, B.columns);
            Matrix<double> P2 = new Matrix<double>(A.rows, B.columns);
            Matrix<double> P3 = new Matrix<double>(A.rows, B.columns);
            Matrix<double> P4 = new Matrix<double>(A.rows, B.columns);
            Matrix<double> P5 = new Matrix<double>(A.rows, B.columns);
            Matrix<double> P6 = new Matrix<double>(A.rows, B.columns);
            Matrix<double> P7 = new Matrix<double>(A.rows, B.columns);
            P1 = Subtract(Multiply(a,f),Multiply(a,h));
            P2 = Add(Multiply(a,h),Multiply(b,h));
            P3 = Add(Multiply(c, e), Multiply(d, e));
            P4 = Subtract(Multiply(d, g), Multiply(d, e));
            P5 = Add(Add(Multiply(a, e), Multiply(a, h)),Add(Multiply(d, e), Multiply(d, h)));
            P6 = Subtract(Add(Multiply(b, g), Multiply(b, h)), Add(Multiply(d, g), Multiply(d, h)));
            P7 = Subtract(Add(Multiply(a, e), Multiply(a, f)), Add(Multiply(c, e), Multiply(c, f)));
            s = Add(P1, P2);
            t = Add(P3, P4);
            r = Subtract(Add(Add(P5, P4), P6), P2);
            u = Subtract(Add(P5, P1), Add(P3, P7));
            for (int i = 0; i <= (A.rows / 2) - 1; i++)
                for (int j = 0; j <= (A.columns / 2) - 1; j++)
                    C.M[i, j] = r.M[i, j];
            for (int i = 0; i <= (A.rows / 2) - 1; i++)
                for (int j = (A.columns / 2); j <= A.columns - 1; j++)
                    C.M[i, j] = s.M[i, j - (A.columns / 2)];
            for (int i = (A.rows / 2); i <= A.rows - 1; i++)
                for (int j = 0; j <= (A.columns / 2) - 1; j++)
                    C.M[i, j] = t.M[i - (A.rows / 2), j];
            for (int i = (A.rows / 2); i <= A.rows - 1; i++)
                for (int j = (A.columns / 2); j <= A.columns - 1; j++)
                    C.M[i, j] = u.M[i - (A.rows / 2), j - (A.columns / 2)];
            return C;
        }
        public Vector<double> LUP_Solve(Matrix<double> L,Matrix<double> U,int[] Pi,Vector<double> b)//Tetha(n^2)
        {
            int n = L.rows;
            double S = 0;
            Vector<double> y = new Vector<double>(n, 1, true, false), x = new Vector<double>(n, 1, true, false);
            for(int i=0;i<=n-1;i++)
            {
                for(int j=0;j<=i-1;j++)
                    S += L.M[i, j] * y.MV[j, 0];
                y.MV[i, 0] = b.MV[Pi[i],0] - S;
                S = 0;
            }
            for(int i=n-1;i>=0;i--)
            {
                for (int j = i+1; j <= n-1; j++)
                    S += U.M[i, j] * x.MV[j, 0];
                x.MV[i, 0] = (y.MV[i,0] - S)/U.M[i,i];
                S = 0;
            }
            return x;
        }
        public void LU_Decomposition(Matrix<double> A,Matrix<double> L,Matrix<double> U)//Tetha(n^3)
        {
            int n = A.rows;
            //Matrix<double> L = new Matrix<double>(n, n), U = new Matrix<double>(n, n);
            for(int k=0;k<=n-1;k++)
            {
                U.M[k, k] = A.M[k, k];
                for(int i=k+1;i<=n-1;i++)
                {
                    L.M[i, k] = A.M[i, k] / U.M[k, k];
                    U.M[k, i] = A.M[k, i];
                }
                for (int i = k + 1; i <= n - 1; i++)
                    for(int j=k+1;j<=n-1;j++)
                        A.M[i, j] -= L.M[i, k] * U.M[k, j];
            }
        }
        public void LUP_Decomposition(Matrix<double> A,Matrix<double> L,Matrix<double> U,ref int[] Pi)//Tetha(n^3)
        {
            int n = A.rows,kp=0,temp=0;
            double Double_Temp = 0,P=0;
            Pi = new int[n];
            for(int i=0;i<=n-1;i++)
                Pi[i] = i;
            for (int k = 0; k <= n - 1; k++)
            {
                P = 0;
                for(int i=k;i<=n-1;i++)
                    if (Math.Abs(A.M[i, k]) > P)
                    {
                        P = Math.Abs(A.M[i, k]);
                        kp = i;
                    }
                if (P == 0)
                    return;
                temp = Pi[k];
                Pi[k] = Pi[kp];
                Pi[kp] = temp;
                for (int i = 0; i <= n - 1; i++)
                {
                    Double_Temp = A.M[k, i];
                    A.M[k, i] = A.M[kp, i];
                    A.M[kp, i] = Double_Temp;
                }
                for(int i=k+1;i<=n-1;i++)
                {
                    A.M[i, k] = A.M[i, k] / A.M[k, k];
                    for(int j=k+1;j<=n-1;j++)
                        A.M[i, j] -= A.M[i, k] * A.M[k, j];
                }
            }
            for(int i=0;i<=n-1;i++)
                for(int j=0;j<=n-1;j++)
                    if (j >= i)
                        U.M[i, j] = A.M[i,j];
                    else
                        L.M[i, j] = A.M[i,j];
        }
        public Matrix<double> Inverse_With_LUP_Decomposition(Matrix<double> A)//Tetha(n^3)
        {
            Matrix<double> X = new Matrix<double>(A.rows, A.columns), L = new Matrix<double>(A.rows, A.columns), U = new Matrix<double>(A.rows, A.columns), I = new Matrix<double>(A.rows, A.columns);
            int[] Pi = new int[A.rows];
            for(int j=0;j<=I.rows-1;j++)
                I.M[j, j] = 1;
            Vector<double> x = new Vector<double>(X.rows, 1, true, false);
            Vector<double> i = new Vector<double>(X.rows, 1, true, false);
            LUP_Decomposition(A, L, U, ref Pi);
            for(int j=0;j<=A.columns-1;j++)
            {
                for (int k = 0; k <= A.rows - 1; k++)
                {
                    x.MV[k, 0] = X.M[k, j];
                    i.MV[k, 0] = I.M[k, j];
                }
                x = LUP_Solve(L, U, Pi, i);
                for (int k = 0; k <= A.rows - 1; k++)
                    X.M[k, j] = x.MV[k, 0];
            }
            return X;
        }
        public Matrix<double> Quadratic_Polynomial_Least_Squares_Approximation_Curve_Fitting(double[] x, double[] y)
        {
            Matrix<double> A = new Matrix<double>(x.Length, 3), Pseudoinverse = new Matrix<double>(3, x.Length), C = new Matrix<double>(3, 1), Y = new Matrix<double>(y.Length, 1);
            for (int i = 0; i <= A.rows-1; i++)
            {
                A.M[i, 0] = 1;
                A.M[i, 1] = x[i];
                A.M[i, 2] = x[i]*x[i];
                Y.M[i, 0] = y[i];
            }
            Pseudoinverse = Multiply(Inverse_With_LUP_Decomposition(Multiply(Transpose(A), A)), Transpose(A));
            C = Multiply(Pseudoinverse, Y);
            return C;
        }
    }
    //public enum Vector_Data_Structure_Properties { a vector is a one-dimensional array of numbers,>>>>we take the standard form of a vector to be as a column vector equivalent to an n*1 matrix the corresponding row vector is obtained by taking the transpose ,>>>>unit vector ei is the vector whose ith element is 1 and other are 0  };
    //public enum Linearly_Dependent_Vector_Data_Structure_Properties { the vectors x1,x2,...,xn are linearly dependent if there exists coefficients c1,....,cn not all of which are zero such that c1x1+c2x2+....+cnxn=0 if vectors are not linearly dependent they are linearly independent };
    public class Vector<T> : Matrix<T>, ICloneable where T : IComparable
    {
        public int columns, Rows;
        public T[,] MV;
        public bool Is_Column_Vector = false, Is_Row_Vector = false;
        public Vector(T[,] init, int r, int c, bool IsColumnVector, bool IsRowVector):base(init,r,c)
        {
            MV = new T[r, c];
            for (int i = 0; i <= r - 1; i++)
                for (int j = 0; j <= c - 1; j++)
                    MV[i, j] = init[i, j];
            Rows = r;
            columns = c;
            Is_Column_Vector = IsColumnVector;
            Is_Row_Vector = IsRowVector;
        }
        public Vector(int r, int c, bool IsColumnVector, bool IsRowVector): base( r, c)
        {
            MV = new T[r, c];
            for (int i = 0; i <= r - 1; i++)
                for (int j = 0; j <= c - 1; j++)
                    MV[i, j] = default(T);
            Rows = r;
            columns = c;
            Is_Column_Vector = IsColumnVector;
            Is_Row_Vector = IsRowVector;
        } 
        #region ICloneable Members

        object  ICloneable.Clone()
        {
 	        return MemberwiseClone();
        }

        #endregion
        //public enum Inner_Product_Algorithm_Properties { if x and y are vectors of size n then xTy=Zigma(i=1...n)xi*yi is a number called the inner product of x and y };
        public double Inner_Product(Vector<double> x, Vector<double> y)
        {
            return x.Multiply(x.Transpose(x), y).M[0, 0];
        }
        //public enum Outer_Product_Algorithm_Properties { the matrix x(yT) is an n*n matrix Z called the outer product of x and y with zij=xiyj };
        public Matrix<double> Outer_Product(Vector<double> x, Vector<double> y)
        {
            return x.Multiply(x, y.Transpose(y));
        }
        //public enum Euclidean_Norm_Algorithm_Properties { the (euclidean) norm ||x|| of a vector x of size n is defiend by ||x||=((x1)^2 +(x2)^2+...+(xn)^2)^(1/2)=(x^(T)*x)^(1/2) thus the norm of x is its length in n-dimensional euclidean space };
        public double Euclidean_Norm(Vector<double> x)
        {
            return Math.Sqrt((double)x.Inner_Product((Vector<double>)x.Transpose(x), x));
        }
    }
    //public enum Sparse Matrix Data Structure Properties { a matrix which has many zero entries there is no precise definition of when a matrix is sparse and when its not but its a concept that we can all recognize intuitiely a sparse matrix requires us to consider an alternative form of representation this comes about because in practice many of the matrices we want to deal with are large eg 5000 in 5000 but at the same time they are sparse say only 5000 of 25 million possible eelmnts are nonzero but if we use array we need 25 milion unit space also 25 million,>>>>as previous units of time are needed for operations such as addition and transposion so we need a representation before doing so we must consider operations on matices a minimum set of operations includes matrx creation transposition addition and multiplication so for representation we characterize any ellemnt within a matrix by suing the riple row column value meaning we can use an array of triples to represnt a aparse marix we require these triples be stored by rows with the triples for the first row,>>>>as previous first followed by those of secondrow and so on we also reuire all the triples for any row be stored so that column indices are in ascending order in addition to ensure the operations terminate we must know number of rows and columns and number of nonzero ellemnts in matix };
    public class SparseMatrix_Array<T> : Matrix<T>, ICloneable where T : IComparable
    {
        public int Terms = 0,Capacity=0;
        public SparseMatrix_Array_Term<T>[] smArray;
        public SparseMatrix_Array(int rows,int colummns,int number_of_terms,int capacity):base(rows,colummns)
        {
            Terms = number_of_terms;
            Capacity = capacity;
            smArray = new SparseMatrix_Array_Term<T>[Capacity];
            for (int i = 0; i <= Capacity - 1; i++)
                smArray[i] = new SparseMatrix_Array_Term<T>();
        }
        #region ICloneable Members

        object ICloneable.Clone()
        {
            return MemberwiseClone();
        }

        #endregion
        //public enum Sparse_Matrix_Transpose_Algorithm_Properties { to_transpose_a_matrix_we_must_interchange_the_rows_and_columns_meaning_elelmt_in_position_i_j_in_main_matrix_then_its_in_position_j_i_in_transposed_matrix_when_i_equasl_j_digonal_ellemnts_dont_change_sinc_original_matrix_is_organized_by_rows_our_first_idea_for_transpose_is_for_each_row_i_store_i_j_value_of_original_matrix_as_j_i_value_of_trasposethe_difficulty_is_not_knowing_where_to_put_the_elelmnt_j_i_value_util_other_elelmnts_preceding_it_have_been_processsed_we_avoid_this_problem_by_changing_order,as_prev_which_we_place_elelmnts_into_transpose_so_that_for_all_elelemnts_in_column_j_staore_i_j_value_of_original_matrix_as_j_i_vlaue_of_transpose_this_says_find_elelmts_in_coumn_0_store_tehm_in_row_0_so_for_all_coumns_are_so_since_the_rows_originally_are_in_order_thid_means_we_will_locate_elelmts_in_correct_coulmn_order_as_well_variable_cuurentB_always_gives_us_the_position_in_b_wher_next_term_in_transpose_is_to_be_inserted_terms_in_b_dot_smArray_are_generated_by_rows_since_rows_of_b_are_the_columns_of,as_prev_this_row_c_of_b_is_obtained_by_collecting_all_nonzero_terms_in_column_c_of_this,to_analyze_running_time_of_this_program_we_mention_if_part_after_two_loops_takes_term_in_columns_time_in_if_block_takes_terms_times_since_there_are_only_this_many_nonzero_terms_in_the_sparse_matrix_being_generated_also_first_3_lines_take_constant_time_to_total_is_O_colun_multily_term_ };
        public SparseMatrix_Array<T> Transpose()//O(columns*Terms)
        {
            SparseMatrix_Array<T> b = new SparseMatrix_Array<T>(columns, rows, Terms,Capacity);
            if (Terms>0)
            {
                int currentB = 0;
                for (int c = 0; c <= columns; c++)
                    for (int i = 0; i <= Terms-1; i++)
                        if (smArray[i].column == c)
                        {
                            b.smArray[currentB].row = c;
                            b.smArray[currentB].column = smArray[i].row;
                            b.smArray[currentB++].Value = smArray[i].Value;
                        }
            }
            return b;
        }
        //public enum Sparse_Matrix_FastTranspose_Algorithm_Properties { the_somputing_time_of_transpse_algorithm_is_a_littele_disturbing_since_we_have_timr_O_cols_multily_rows_for_trasnpose_of_matrices_in_two_dimensional_array_the_O_terms_multiply_cols_time_for_function_transpose_becomes_O_rows_multily_cols_power_2_when_terms_is_of_the_order_of_rows_multiply_colsthis_is_worse_than_O_rows_in_cols_for_suual_metod_so_by_conserving_space_we_have_traded_away_too_much_time_but_we_can_transpose_a_matrix_in_time_O_terms_plus_cols_using_a_littele_more_sapce_this_algorithm_starts_by,as_prev_first_determining_number_of_elelmnts_ineach_column_of_this_this_gives_us_the_number_of_elelmnts_in_each_row_of_b_then_we_find_starting_point_in_b_of_each_of_its_rows_is_easily_obtained_so_starting_point_rowStart_i_of_row_i_of_b_is_rowSart_i_minus_1_plus_rowSize_i_minus_1_then_we_place_elelmnts_of_this_one_by_one_into_the_corect_place_in_b_roeStart_j_is_maintained_so_that_its_always_the_position_inb_where_the_next_elelmnt_in_row_j_of_b_is_to_be_inserted,to_analyze_this_program_there_are_three_loops_in_this_algorithm_executed_terms_cols_minus_1_and_terms_times_respectively_each_iteration_of_each_loop_takes_a_xonstant_time_so_for_all_loops_time_is_O_cols_plus_terms_so_its_algorithm_total_timethe_computing_time_of_O_cols_plus_terms_becomes_O_rows_multiply_cols_when_terms_is_of_the_order_of_rows_multily_cols_same_as_when_two_dimensional_arrays_were_in_use_bu_constsnt_factor_associed_with_FastTranspose_is_larger_han_for_array_algorithm_when_terms_are,as_prev_sufficiently_small_compared_to_rows_in_cols_FastTranspose_is_fasterits_not_trie_for_Transpose_since_terms_will_almost_be_greater_than_max_rows_and_cols_and_cols_in_terms_will_therefore_always_be_atleast_rows_in_colsalso_constant_factor_for_Traspose_is_larger_than_usual_method };
        public SparseMatrix_Array<T> FastTranspose()//O(columns+Terms)
        {
            SparseMatrix_Array<T> b = new SparseMatrix_Array<T>(columns, rows, Terms,Capacity);
            if (Terms > 0)
            {
                int[] rowSize = new int[columns], rowStart = new int[columns];
                for (int i = 0; i <= Terms-1; i++)
                    rowSize[smArray[i].column]++;
                rowStart[0] = 0;
                for (int i = 1; i <= columns - 1; i++)
                    rowStart[i] = rowStart[i - 1] + rowSize[i - 1];
                for (int i = 0; i <= Terms - 1; i++)
                {
                    int j = rowStart[smArray[i].column];
                    b.smArray[j].row = smArray[i].column;
                    b.smArray[j].column = smArray[i].row;
                    b.smArray[j].Value = smArray[i].Value;
                    rowStart[smArray[i].column]++;
                }
            }
            return b;
        }
        public void StoreSum(SparseMatrix_Array<double> a, double sum, int r, int c)
        {
            if (sum != 0)
            {
                if (Terms == Capacity)
                    ChangeSize1D(2 * Capacity);
                a.smArray[Terms].row = r;
                a.smArray[Terms].column = c;
                a.smArray[Terms++].Value = sum;
            }
        }
        private void ChangeSize1D(int NewSize)
        {
            if (NewSize < Terms)
                return;
            SparseMatrix_Array_Term<T>[] temp = new SparseMatrix_Array_Term<T>[NewSize];
            for (int i = 0; i <= temp.Length - 1; i++)
                temp[i] = new SparseMatrix_Array_Term<T>();
            for (int i = 0; i <= smArray.Length-1; i++)
                temp[i] = smArray[i];
            smArray = temp;
            Capacity = NewSize;
        }
        //SparseMatrix<double> SM = new SparseMatrix<double>(4, 5, 5, 5);
        //SparseMatrixTerm<double> SMT = new SparseMatrixTerm<double>();
        //SMT.row = 0;
        //SMT.column = 1;
        //SMT.Value = 2;
        //SM.smArray[0] = SMT;
        //SMT = new SparseMatrixTerm<double>();
        //SMT.row = 0;
        //SMT.column = 3;
        //SMT.Value = -1;
        //SM.smArray[1] = SMT;
        //SMT = new SparseMatrixTerm<double>();
        //SMT.row = 2;
        //SMT.column = 0;
        //SMT.Value = 7;
        //SM.smArray[2] = SMT;
        //SMT = new SparseMatrixTerm<double>();
        //SMT.row = 2;
        //SMT.column = 2;
        //SMT.Value = 0.5;
        //SM.smArray[3] = SMT;
        //SMT = new SparseMatrixTerm<double>();
        //SMT.row = 3;
        //SMT.column = 1;
        //SMT.Value = 1.25;
        //SM.smArray[4] = SMT;
        //SparseMatrix<double> SMB = new SparseMatrix<double>(5, 4, 5, 5);
        //SparseMatrixTerm<double> SMTB = new SparseMatrixTerm<double>();
        //SMTB.row = 0;
        //SMTB.column = 0;
        //SMTB.Value = 3;
        //SMB.smArray[0] = SMTB;
        //SMTB = new SparseMatrixTerm<double>();
        //SMTB.row = 1;
        //SMTB.column = 2;
        //SMTB.Value = 2.5;
        //SMB.smArray[1] = SMTB;
        //SMTB = new SparseMatrixTerm<double>();
        //SMTB.row = 2;
        //SMTB.column = 1;
        //SMTB.Value = 3;
        //SMB.smArray[2] = SMTB;
        //SMTB = new SparseMatrixTerm<double>();
        //SMTB.row = 2;
        //SMTB.column = 3;
        //SMTB.Value = 1;
        //SMB.smArray[3] = SMTB;
        //SMTB = new SparseMatrixTerm<double>();
        //SMTB.row = 4;
        //SMTB.column = 1;
        //SMTB.Value = 1;
        //SMB.smArray[4] = SMTB;
        //SM.Multiply(SM, SMB);
        //public enum Sparse_Matrix_Multiply_Algorithm_Properties { the_product_of_two_matrices_may_no_longer_be_sparse_we_want_to_multiply_two_sparse_matrices_a_and_b_represented_as_ordeed_lists_we_need_to_compute_the_elelmnts_of_d_by_rows_so_that_we_can_store_them_in_their_proper_place_without_moving_previousely_computed_elelmnts_to_do_this_we_pick_a_row_of_a_and_find_all_elements_in_column_j_of_b_for_j_0_1_to_b_dot_cols_minus_1_but_in_this_way_we_would_have_to_scan_all_b_to_find_all_elelmnts_in_column_j_to_avoid_it_we_first_compute_the_transpose_of_b_this_puts_all,as_prev_column_elelmnts_in_consecutive_order_then_after_finding_elelmnts_of_row_i_of_A_and_column_j_of_b_we_justdo_a_merge_operation_like_for_polynomials_in_program_variable_currRowA_is_the_row_of_a_curently_being_multilpied_with_columns_of_b_currRowBegin_is_position_in_a_of_the_first_elelmnt_of_row_currRowA_and_currColB_is_the_column_of_b_currenly_being_multiplied_with_row_currRowA_of_a_varibles_currRowIndex_and_currColIndex_are_used_to_examine_successive_elelmnts_of_row_currRowA_and_column_currColB_of,as_prev_a_and_b_respectively_we_also_can_introduce_a_dummy_term_into_each_of_a_and_BXpose,to_anayze_this_program_we_know_that_FastTranspose_take_O_b_dot_cols_plus_b_dot_terms_oterwhile_loop_is_executed_at_most_a_dot_rows_times_inner_while_in_its_each_itertaion_value_of_currRowIndex_or_currColIndex_or_both_incraeses_by_1_or_currRowIndex_and_currColB_are_rsest_maximum_increment_of_currColIndex_over_whole_loop_is_b_dot_terms_if_tr_is_number_of_terms_in_row_r_of_a_then_value_of_currRowIndex_can_increase_atmost_tr_times_be4_currRowIndex_moves_to_the_next_row_of_awhen_it_happens_currRowIndex_is_reset,as_prev_to_currRowBegin_at_the_same_time_currColB_is_advanced_to_next_xolumn_so_resettng_can_ake_place_at_bdotdcols_timesso_total_maximum_increment_in_currRowIndex_is_therefore_b_dot_cols_multiply_trmaximum_itration_of_inner_loop_is_b_dot_cols_lpus_b_dot_cols_multiply_tr_plus_b_dot_terms_so_its_O_bdotcols_multilpy_tr_plus_b_dot_termssecond_while_takes_O_tr_overall_time_for_this_loop_is_O_Zigma_r_b_dot_cols_multiply_tr_plus_b_dot_terms_equasl_O_b_dot_cols_multiply_a_dot_terms_plus_a_dot_rows_plus_b_dot,as_prev_terms_to_compare_result_with_usual_multiplying_which_is_O_a_dot_rows_multiply_d_dot_cols_dot_b_dot_cols_since_a_dotterms_smaller_equsl_a_dot_rows_multiply_a_dot_cols_and_b_dot_terms_smaller_ewqual_a_dot_cols_multiply_b_dot_roes_time_to_muliply_is_atmost_O_arows_in_a_cols_in_bcolsbut_its_contant_factor_is_graeter_than_array_matrixmultiplication_in_worse_case_this_methopd_is_wosre_than_usual_since_its_constant_factor_but_in_sparse_matrices_its_better };
        public SparseMatrix_Array<double> Multiply(SparseMatrix_Array<double> a, SparseMatrix_Array<double> b)
            //O(b.columns*a.Terms+a.rows*b.Terms)
        {
            if (a.columns != b.rows)
                return null;
            SparseMatrix_Array<double> bXpose = b.FastTranspose();
            SparseMatrix_Array<double> d = new SparseMatrix_Array<double>(a.rows, b.columns, 0, Capacity);
            int currRowIndex = 0, currRowBegin = 0, currRowA = a.smArray[0].row;
            if (a.Terms == a.Capacity)
                a.ChangeSize1D(a.Terms + 1);
            bXpose.ChangeSize1D(bXpose.Terms + 1);
            a.smArray[Terms].row = a.rows;
            bXpose.smArray[b.Terms].row = b.columns;
            bXpose.smArray[b.Terms].column = -1;
            double sum = 0;
            while (currRowIndex < a.Terms)
            {
                int currColB = bXpose.smArray[0].row,currColIndex=0;
                while (currColIndex <= b.Terms)//currColIndex=3
                {
                    if (a.smArray[currRowIndex].row != currRowA)
                    {
                        d.StoreSum(d,sum, currRowA, currColB);
                        sum = 0;
                        currRowIndex = currRowBegin;
                        while (bXpose.smArray[currColIndex].row == currColB)
                            currColIndex++;
                        currColB = bXpose.smArray[currColIndex].row;
                    }
                    else if (bXpose.smArray[currColIndex].row != currColB)
                    {
                        d.StoreSum(d,sum, currRowA, currColB);
                        sum = 0;
                        currRowIndex = currRowBegin;
                        currColB = bXpose.smArray[currColIndex].row;
                    }
                    else
                        if (a.smArray[currRowIndex].column < bXpose.smArray[currColIndex].column)
                            currRowIndex++;
                        else if (a.smArray[currRowIndex].column == bXpose.smArray[currColIndex].column)
                        {
                            sum += a.smArray[currRowIndex].Value * bXpose.smArray[currColIndex].Value;
                            currRowIndex++;
                            currColIndex++;
                        }
                        else
                            currColIndex++;
                }
                while (a.smArray[currRowIndex].row == currRowA)
                    currRowIndex++;
                currRowBegin = currRowIndex;
                currRowA = a.smArray[currRowIndex].row;
            }
            return d;
        }
    }
    public class SparseMatrix_Array_Term<T>
    {
        public int row = 0, column = 0;
        public T Value;
    }
    //public enum Sparse_Matrix_Linked_Representation_Properties { in sparse mateices sequetial representation we have easy access of matrix terms by row but accessing all the terms in a specific column of a matrix is difficult to provide easy access both by row and by column we devise a linked representation for a sparse matrixin that we use ach nonzero elelmnt is in two circular lists one is a row list and the other a column listso we have a circular list for each row and each column of matrix this representation uses nodes of type MatrixNode it has a boolean field head used to distinguish between header nodes and nodes rpresenting nonzero elementseach header node has three additional fields:down right and nexttotal number of header nodes is max{number of nodes number of columns}header node for row i is also header node for column i the down field of a header node is used to link into column list the right field is used to link into a row list the next fieldlinks the header nodes together all other nodes have six fields:head row col value down and right the down field is used to link to the next nonzero term in the same coulmn and teh right field links to the next nonzero term in the same rowif aij!=0 then there is a node with head=fasle value=aij row=i and col=jthis node is linked into the circular ;istsfor row i and column j so node is simultaneously in two different listsheader nodes are in three lists:a row list a column list and a list of header nodes list of header nodes itself has a header node H identical to nodes used to represent nonzero elelmnts the rowand col fields of this node are used to store the matrix dimensions entire matrix is represented by class Matrix with data member headnode which points to H and right field of headnode is used to link into the list of header nodes and row col and value fields are all incorporated into the struct Triple,>>>>if we wish to represent an n*m sparse matix with r nonzero terms number of nodes needed is max{n,m}+r+1 although each node may require several words of memory the total storage needed will be less than nm for sufficiently small r};
    public class SparseMatrix_Linked_List<K,T>: Matrix<K>,ICloneable where T:IComparable where K:IComparable
    {
        //Triple<int>[] input = new Triple<int>[6];
        //input[0] = new Triple<int>();
        //input[0].row=0;
        //input[0].col = 0;
        //input[0].value = 2;
        //input[1] = new Triple<int>();
        //input[1].row = 1;
        //input[1].col = 0;
        //input[1].value = 4;
        //input[2] = new Triple<int>();
        //input[2].row = 1;
        //input[2].col = 3;
        //input[2].value = 3;
        //input[3] = new Triple<int>();
        //input[3].row = 3;
        //input[3].col = 0;
        //input[3].value = 8;
        //input[4] = new Triple<int>();
        //input[4].row = 3;
        //input[4].col = 3;
        //input[4].value = 1;
        //input[5] = new Triple<int>();
        //input[5].row = 4;
        //input[5].col = 2;
        //input[5].value = 6;
        //SparseMatrix_Linked_List<int,Triple<int>> SPLL = new SparseMatrix_Linked_List<int,Triple<int>>(4, 5);
        //SPLL=SPLL.Matrix_Input(4, 5, 6, input);
        //SPLL.Matrix_Output();
        private SparseMatrix_Linked_List_Node<T> headnode = null;
        public SparseMatrix_Linked_List(int rows, int colummns): base(rows, colummns)
        {

        }
        //public enum Matrix_Input_Algorithm_Properties { its operation is raeding in a sparse matrix and obtaining its linked representation we assume first input line gives us number of rows columns and nonzero terms each in triple (i,j,aij) we also assume these triples are ordered by rows and within rows by columns program use an auxiliary array head of size max(s.row,s.col) head[i] is a pointer to header node for column i and hence row ienables efficient random access to columns while input matrix is set up program first creates the header nodes and then inputs the matrix elements one at a time eac elelmnt is added to its row and column lists upo input next field of header node i is used initially to keep track of the last node in column i in line 31 header nodes are linked together through this field,to analyze its runing time assuming new works in O(1) time all header nodes may set up in O(max{n,m}) time n number of row m number of columnseach nonzero term is set up in O(1) timebecause use of variable last and a random access acheme for bottommmost node i neach column listso for loop of lines 15-26 takes O(r) time rest of algorithm takes O(max{n,m}) time total time therefore is O(max{n,m}+r)=O(n+m+r) this time is asymptotically better than input time of O(mn) for an n*m matrix using two dimesnional array but worse than that for sequetial sparse method };
        public SparseMatrix_Linked_List<K, Triple<K>> Matrix_Input(int Row_Number, int Column_Number, int Non_Zero_Term_Number, Triple<K>[] Matrix_Terms)//O(n+m+r)n~number of matrix rows,m~number of matrix columns,r~number of matrix terms
        {
            SparseMatrix_Linked_List<K, Triple<K>> matrix = new SparseMatrix_Linked_List<K, Triple<K>>(Row_Number, Column_Number);
            Triple<K> s = new Triple<K>();
            int p = 0;
            if (Row_Number > Column_Number)
                p = Row_Number;
            else
                p = Column_Number;
            s.row = Row_Number;
            s.col = Column_Number;
            s.terms_number = Non_Zero_Term_Number;
            matrix.headnode = new SparseMatrix_Linked_List_Node<Triple<K>>(false, s);
            if (p == 0)
            {
                matrix.headnode.right = matrix.headnode;
                return matrix;
            }
            SparseMatrix_Linked_List_Node<Triple<K>>[] head = new SparseMatrix_Linked_List_Node<Triple<K>>[p];
            for (int i = 0; i < p; i++)
                head[i] = new SparseMatrix_Linked_List_Node<Triple<K>>(true, null);
            int currentRow = 0;
            SparseMatrix_Linked_List_Node<Triple<K>> last = head[0];
            for (int i = 0; i < s.terms_number; i++)
            {
                Triple<K> t = null;
                t = Matrix_Terms[i];
                if (t.row > currentRow)
                {
                    last.right = head[currentRow];
                    currentRow = t.row;
                    last = head[currentRow];
                }
                last = last.right = new SparseMatrix_Linked_List_Node<Triple<K>>(false, t);
                head[t.col].next = head[t.col].next.down = last;
            }
            last.right = head[currentRow];
            for (int i = 0; i < s.col; i++)
                head[i].next.down = head[i];
            for (int i = 0; i < p - 1; i++)
                head[i].next = head[i + 1];
            head[p - 1].next = matrix.headnode;
            matrix.headnode.right = head[0];
            return matrix;
        }
        //public enum Matrix_Output_Algorithm_Properties { all nodes of matrix may be returned one at a time using delete a faster way to return the nodes is to set up an available spacelistwe assume av points to frst node of this list and list is linked through field right,>>>>to analyze its running time since each ndoe is in only one row list its sffcient to return all the row lists of th ematrixsince each row is circularly linked through field right node dont need to be reurned one by on esince circular list can be deleted on O(1) timeso algorithm computing time is O(m+n)its running time will be the same if lst had been linked through field down };
        public SparseMatrix_Linked_List_Node<T> Matrix_Output()//O(n+m)n~number of matrix rows,m~number of matrix columns
        {
            if (headnode == null)
                return null;
            SparseMatrix_Linked_List_Node<T> x = headnode.right;
            SparseMatrix_Linked_List_Node<T> av = null;
            headnode.right =av;
            av = headnode;
            while (x != headnode)
            {
                SparseMatrix_Linked_List_Node<T> y = x.right;
                x.right =av;
                av = y;
                x = x.next;
            }
            headnode = null;
            return av;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public class SparseMatrix_Linked_List_Node<T>:Circular_Doubly_Linked_List<T>,ICloneable where T:IComparable
    {
        public SparseMatrix_Linked_List_Node<T> down, right,next;
        bool head;
        public SparseMatrix_Linked_List_Node(bool b, T t)
        {
            head = b;
            if (b)
            {
                right = down = next=this;
            }
            else
                key = t;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public class Triple<K>:IComparable
    {
       public int row, col,terms_number;
       public K value;
       #region IComparable Members

       public int CompareTo(object obj)
       {
           throw new NotImplementedException();
       }

       #endregion
    }
}
