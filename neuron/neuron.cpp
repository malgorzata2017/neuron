#include "neuron.h"
#include <iostream>
using namespace std;

neuron::neuron(){
	n=0.7; 
}


void neuron::wejscia_fun(int ile){
	wejscia=new double[ile+1];//bo w0
	wagi=new double[ile+1];
	wejscia[0] = 1;
	this->ile= ile;
}
 
void  neuron:: oblicz_s(){

	s= wejscia[0]; 
	for(int i=1; i<ile+1;  i++)
	{
		s+= wejscia[i]*wagi[i]; 
	}
		
}
	 
void neuron:: oblicz_y()
	{
	if(s>=0)
		y=1; 
	else y=0; 

	cout << "liczenie y:" << y << " " << wejscia[0] << " "  << wejscia[1] << " "  << wejscia[2] << " "  << wagi[1] << " "  << wagi[2] << endl;
	}
	
void neuron:: zmien_wagi(double d)
	{
		for(int i=1; i<ile+1; i++)
		{	
			wagi[i]+= n*(d-y)*wejscia[i];
		
		}

		wejscia[0]+=n*(d-y);
					
		}
