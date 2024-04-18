using System;

namespace Prime.Services
{
    public class PrimeService
    {
	public bool IsPrime(int candidate)
	{
		int n = candidate, a = 0;
		for (int i = 1; i <= n; i++) {
            		if (n % i == 0) {
               			a++;
            		}		
         	}
		if (a == 2) {
            		return true;
         	} else {
            		return false;
         	}
	}	

    }
}
