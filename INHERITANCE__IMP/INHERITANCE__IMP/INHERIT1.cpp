# include<iostream>
# include<conio.h>
# include<stdlib.h>
# include<string>
using namespace std;
class parent{
protected:
	string name;
	float price;
	void getData(string a,float b){
	name = a;
	price = b;
	}
	string putDatatitle(){
	return name;
	}
	float getDataprice(){
	return price;
	}
};
class book : public parent{
private:
	int count;
public:


};