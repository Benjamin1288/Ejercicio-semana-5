static double area_c(int radio)
{
    double area = (radio * radio * Math.PI);
    return area;
}
static double re(int anc,int alt)
{
    int perimetro=anc*alt;
    return perimetro;
}
static int prom(int n1, int n2, int n3, int n4)
    {
    int suma = n1 + n2 + n3 + n4;
    int promedio = suma / 4;
    return promedio;
    }
static string poi(int par)
{
    string var;
    if (par%2==0)
    {
        var = "Par";
    }
    else
    {
        var = "Impar";
    }
    return var;
}
static string cos(string cosa)
{
    string cosa1;
    cosa1 = cosa.ToUpper();
    return cosa1;
}
static double pun(int x1,int x2,int y1,int y2)
{
    double suma= Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2);
    double raiz = Math.Sqrt(suma);
    return raiz;
}
static int sum(int nn)
{
    int suma = nn + 1 + 2 + 3 + 4 + 5;
    return suma;
}
static int facto(int fact,int factorial_real)
{
    for (int i = 1; i <= fact;i++)
    {
        factorial_real = factorial_real * i;
    }
    return factorial_real;
}

double cir,rec,dis;
int radio,n1,n2,n3,n4,promedio_r,par,x1,x2,y1,y2;
int anc,alt,nn,nnf,fact,factorial,factorial_real;
string quiensabe,cosa,cosa2;

//1*
Console.Write("Ingrese el area del radio: ");
radio=int.Parse(Console.ReadLine());
cir=area_c(radio);
Console.WriteLine("El area del circulo es: "+cir);
Console.ReadLine();

//2*
Console.Write("Ingrese el ancho: ");
anc=int.Parse(Console.ReadLine());
Console.Write("Ingrese la altura: ");
alt = int.Parse(Console.ReadLine());
rec=re(anc,alt);
Console.WriteLine("El perimetro del rectangulo es: "+rec);
Console.ReadLine();

//3*
Console.Write("Ingrese el primer número: ");
n1= int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
n2= int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer número: ");
n3= int.Parse(Console.ReadLine());
Console.Write("Ingrese el cuarto número: ");
n4=int.Parse(Console.ReadLine());
promedio_r = prom(n1,n2,n3,n4);
Console.WriteLine("El promedio de los 4 números ingresados es: " + promedio_r);
Console.ReadLine();

//4*
Console.Write("Ingrese un número: ");
par=int.Parse(Console.ReadLine());
quiensabe=poi(par);
Console.WriteLine("El número ingreado es: " +quiensabe);
Console.ReadLine();

//5*
Console.Write("Ingrese ya sea una letra o palabra: ");
cosa=Console.ReadLine();
cosa2 = cos(cosa);
Console.WriteLine("Lo que ingreso convertido a mayusculas quedo asi: " + cosa2);
Console.ReadLine();

//6*
Console.Write("Ingrese x1: ");
x1= int.Parse(Console.ReadLine());
Console.Write("Ingrese y1: ");
y1= int.Parse(Console.ReadLine());  
Console.Write("Ingrese x2: ");
x2= int.Parse(Console.ReadLine());
Console.Write("Ingrese y2: ");
y2= int.Parse(Console.ReadLine());
dis=pun(x1,y1,x2,y2);
Console.WriteLine("La distancia entre los puntos son: " + dis);
Console.ReadLine();

//7*
Console.Write("Ingrese un número: ");
nn=int.Parse(Console.ReadLine());
nnf=sum(nn);
Console.WriteLine("El resultado de la suma de su número ingresado con los primeros números naturales es: "+nnf);
Console.ReadLine();

//8*
Console.WriteLine("Ingrese un número");
fact=int.Parse(Console.ReadLine());
factorial_real = 1;
factorial=facto(fact,factorial_real);
Console.WriteLine("La factorial del número ingresado es: "+factorial);
Console.ReadLine();


