

class neuron {
public:
neuron();


double *wejscia; //w0 bedzie w tym 
void wejscia_fun(int ile); 
double *wagi; 
int ile; 
double s; 
double y; 
void oblicz_s(); 
void oblicz_y(); 
void zmien_wagi(double d);//d poprawny wynik 
double n; //wspolczynnik uczenia, ustalam domyslnie
}; 