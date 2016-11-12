
#include "AND.h"


	
	void AND::generuj_dane(int losowanie){

		losowanie = losowanie%4;
		skladowa1 = losowanie%2;
		skladowa2 = losowanie/2;

		if ((skladowa1==1)&&(skladowa2==1))
			d=1;
		else d=0; 

	}

	void AND::ustaw_wejscia()
	{
		moj_neuron.wejscia[1]=skladowa1; 
		moj_neuron.wejscia[2]=skladowa2; 
	}

	double AND::poprawnosc_neuronu()
	{
		double poprawnosc; 
		int ilosc_poprawnych=0; 

		for(int i=0; i<4; i++)
		{
			this->generuj_dane(i); 
			this->ustaw_wejscia(); 
			moj_neuron.oblicz_s(); 
			moj_neuron.oblicz_y(); 
			if(moj_neuron.y==this->d) 
				 ilosc_poprawnych++; 

		}

		poprawnosc=(double)ilosc_poprawnych/4; 
		return poprawnosc; 
	}