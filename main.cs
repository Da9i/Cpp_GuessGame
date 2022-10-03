#include<iostream>
#include<time.h>
using namespace std;
void guessnumber(int& randnumber)
{
	int num;
	char ch = 'y';
	cout << "I HAVE A NUMBER BETWEEN 1 AND 1000.\nCAN YOU GUESS MY NUMBER?\nPLEASE TYPE YOUR FIRST GUESS:";
	cin >> num;
	do
	{
		if (num == randnumber)
		{
			cout << "EXCELLENT! YOU GUESSED THE NUMBER! WOULD YOU LIKE TO PLAY AGAIN(Y OR N)?";
			cin >> ch;
			if (ch == 'n' || ch == 'N')
				break;
			randnumber = (rand() % 1000) + 1;
		}
		else if (num < randnumber)
		{
			cout << "TOO LOW. TRY AGAIN.";
		}
		else if (num > randnumber)
		{
			cout << "TOO HIGH. TRY AGAIN.";
		}
		cout << "\nENTER GUESSING VALUE AGAIN:";
		cin >> num;
	} while (ch == 'y' || ch == 'Y');

}
int main()
{
	srand(time(0));
	int n = (rand() % 1000) + 1;
	guessnumber(n);
	system("pause>0");
}
