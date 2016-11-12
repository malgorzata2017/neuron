#include <iostream>
using namespace std; 
#include <cstdlib>
#include <cstdio>
#include <ctime>

#include "AND.h"




int main()
{
	srand( time( NULL )) ; 
	AND moj_AND; 
	moj_AND.moj_neuron.wejscia_fun(2); 
	
	
	for(int i=1; i<=2; i++)
	{  moj_AND.moj_neuron.wagi[i]=((double)(rand()%100))/100; 
	}
	int i,j=0;
	while(moj_AND.poprawnosc_neuronu() < 1)
	{
		for(i=0; i<4; i++)
		{
			moj_AND.generuj_dane(i); 
			moj_AND.ustaw_wejscia(); 
			moj_AND.moj_neuron.oblicz_s(); 
			moj_AND.moj_neuron.oblicz_y(); 
			moj_AND.moj_neuron.zmien_wagi( moj_AND.d); 
			cout << moj_AND.poprawnosc_neuronu() << endl;
			j++;
		}
		//cout << "a" ;
		//cin >> j;
	
	}
	cout << "Neuron nauczyl sie po " << (j+1)/4 << " razach" << endl;
	cin >> j;

	return 0;
}