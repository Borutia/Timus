#include <stdio.h>

double Pa, Pb, Total, Max;
long A, B, K, Opta, Optb;


void brute()
{
	Opta = Optb = Max = 0;

	for (A = 0; A <= K; A++)
		for (B = 0; B <= K - A; B++)
		{
			Total = A * Pa + B * Pb - A * A - B * B;
			if (Total > Max)
				Max = Total, Opta = A, Optb = B;
		}
	printf("%.2lf\n%ld %ld\n", Max, Opta, Optb);
}

int main()
{
	scanf("%lf %lf %I64d", &Pa, &Pb, &K);

	brute();
	return 0;
}