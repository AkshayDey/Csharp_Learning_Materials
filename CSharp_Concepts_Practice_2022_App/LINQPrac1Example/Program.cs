using LINQPrac1Example;

AggregateOperators aggregateOperatorsObj = new AggregateOperators();
Conversions aConversion = new Conversions();
ElementOperations aElementOperation = new ElementOperations();
Groupings aGroupingsObj = new Groupings();
Partition aPartition = new Partition();
Projections aProjections = new Projections();
JoinOperations aJoinOperations = new JoinOperations();
QueryExecution aQueryExecution= new QueryExecution();
//aggregateOperatorsObj.CountSyntax();

//aggregateOperatorsObj.CountConditional();
//aggregateOperatorsObj.CountConditional();
//aggregateOperatorsObj.GroupedCount();
//aggregateOperatorsObj.MinGrouped();
//aConversion.ConvertToArray();
//aConversion.CovertToDictionary();
//aConversion.ConvertSelectedItems();
//aElementOperation.FirstElement();
//aElementOperation.FindFirstMatching();

//
//aGroupingsObj.GroupingSyntax();
//aGroupingsObj.GroupByCategory();
//aGroupingsObj.GroupByCategoryProducts();

//aGroupingsObj.GroupByCategorySumOfUnitPrice();
//aggregateOperatorsObj.MinEachGrouped();
//aggregateOperatorsObj.MaxEachGrouped();
//aggregateOperatorsObj.MaxGroup();
//aggregateOperatorsObj.MinProjection();
//aggregateOperatorsObj.AggregateSyntax();

//aPartition.TakeSyntax();
//aPartition.NestedTake();

//aProjections.SelectProperty();
//aProjections.TransformWithSelect();
//aProjections.SelectByCaseAnonymous();
//aProjections.SelectAnonymousConstructions();
//aProjections.SelectWithWhere();
//aProjections.SelectFromMultipleSequences();

//aJoinOperations.CrossJoinQuery();

//aJoinOperations.GroupJoinQquery();
aJoinOperations.CrossGroupJoin();
aQueryExecution.DeferredExecution();

