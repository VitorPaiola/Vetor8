using System.Globalization;

int N = int.Parse(Console.ReadLine());

double[] altura = new double[N];
char[] sexo = new char[N];

// Leitura de dados
for (int i = 0; i < N; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
    sexo[i] = char.Parse(vet[1]);
}

// Menor altura
double menorAltura = altura[0];
for (int i = 0; i < N; i++) {
    if (altura[i] < menorAltura) {
        menorAltura = altura[i];
    }
}

Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));

// Maior altura
double maiorAltura = altura[0];
for (int i = 0; i < N; i++) {
    if (altura[i] > maiorAltura) {
        maiorAltura = altura[i];
    }
}

Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

// Altura das mulheres
double somaAlturaMulheres = 0.0;
int contMulheres = 0;
for (int i = 0; i < N; i++) {
    if (sexo[i] == 'F') {
        somaAlturaMulheres += altura[i];
        contMulheres++;
    }
}

if (contMulheres == 0) {
    Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
} else {
    double media = somaAlturaMulheres / contMulheres;
    Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
}

// Numero de homens
int contHomens = 0;
for (int i = 0; i < N; i++) {
    if (sexo[i] == 'M') {
        contHomens++;
    }
}

Console.WriteLine("Numero de homens = " + contHomens);