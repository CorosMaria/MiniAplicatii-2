// program pentru calculul ariei cercului 
// se cere raza cercului si se afiseaza aria acestuia
// se foloseste procedura aria_c pentru a calcula aria cercului
// Programul este scris in C++ Visual Studio 2005 de tipul:CLR 
// (Common Language Runtime) console application

#include "stdafx.h"
#include < iostream >

using namespace std;
void aria_c(float,float,float&);// prototipul 
int main(void)
{
	float pi=3.1415,r,a=0;
	cout << " \n\n\tIntroduceti raza cercului: ";
	cin >> r;
	aria_c(pi,r,a);
	cout << "\n\n\tAria cercului de raza  ";
	cout << r;
	cout << " este : ";
	cout << a;
	cin.ignore();
	cin.get();
	return 0;
}
// Incepe definirea procedurii aria_c
void aria_c(float p,float raza, float& aria)
{
	aria=p*raza*raza;
}