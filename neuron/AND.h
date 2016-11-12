

#include "neuron.h"

class AND{
public:
	neuron moj_neuron; 
	double d; //poprawny wynik
	double skladowa1; //skladowwe do wyniku
	double skladowa2; 
	void generuj_dane(int losowanie); 
	void ustaw_wejscia(); 
	double poprawnosc_neuronu(); //sprawdzam czy dobrze umie policzyc, sprawdzi wszystkie 4 wyniki

};