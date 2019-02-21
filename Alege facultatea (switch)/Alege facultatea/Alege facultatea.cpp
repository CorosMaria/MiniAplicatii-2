// Alege facultatea.cpp : main project file.

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{ char n;
cout<<"\ta.Facultatea de inginerie.\n\tb.Facultatea de litere\n\tc.Facultatea de stiinte.";
cout<<"\n\nAlege faculatatea:";
cin>>n;
switch (n)
{	case 'a': 
	cout<<"Ati ales facultatea de inginerie.";
	break;
	case 'b':
	cout<<"Ati ales facultatea de litere.";
	break;
	case 'c': 
	cout<<"Ati ales facultatea de stiinte.";
	break;
}
cin.ignore();
cin.get();
    
    return 0;
}
