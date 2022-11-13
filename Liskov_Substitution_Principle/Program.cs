#region Not Ideal Code
using Liskov_Substitution_Principle;

//Cloud cloud = new AWS();
//cloud.MachineLearning();
//cloud.Translate();

//cloud = new Google();
//cloud.Translate();
//cloud.MachineLearning();

//cloud= new Azure();
//cloud.MachineLearning();
//cloud.Translate(); //NotImplmentedException

#endregion

#region IdealCode

Cloud2 cloud2= new AWS2();
cloud2.MachineLearning();
(cloud2 as ITranslatable)?.Translate();

cloud2 = new Google2();
cloud2.MachineLearning();
(cloud2 as ITranslatable)?.Translate();

cloud2 = new Azure2();
cloud2.MachineLearning();
(cloud2 as ITranslatable)?.Translate();


#endregion