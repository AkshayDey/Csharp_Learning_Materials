using ParamModifierExample;

ParamExampleOne aParamOne = new ParamExampleOne();
//aParamOne.Sum(100, 3434);
//aParamOne.Sum(24, 3423, 343);

aParamOne.ShowString(12);

//int 
int p = 100;
aParamOne.Test(ref p);