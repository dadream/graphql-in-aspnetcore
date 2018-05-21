# graphql-in-aspnetcore
# 基于GraphQL with ASP.NET构建
# 地址：http://fiyazhasan.me/graphql-with-asp-net-core/

基于asp.net core，从0开始构建graphql示例

第一部分：Hello World

mkdir asp_graphql
cd asp_graphql
dotnet new web # 新建empty工程

dotnet add package GraphQL --version 2.0.0-alpha-870 # 添加GraphQL包

# 添加helloworld的query/schema和endpoint

第二部分：Middleware

# 演示aspnet core的中间件
# app.run ==> app.UseMiddleware

第三部分： Dependency Injection

# 演示aspnet core 的di和中间件（指定post方法/api/graphql的endpoint）

第四部分： GraphiQL - An in-browser IDE

# 利用graphiql实现graphql的swager ide

npm install -g yarn
npm install -g webpack@3.12.0
yarn install 
webpack

第五部分：  Fields, Arguments, Variables

# 实现graphiql的后端服务，构建query fields，arguments和variables

第六部分：Persist Data

# 利用efcore的postgresql提供者，实现数据的存储
