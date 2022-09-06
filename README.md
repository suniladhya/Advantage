# Advantage
XVIIL
To trim hml Content from the textbox content
HttpUtility.HtmlDecode(Regex.Replace(input, "<[^>]*>", string.Empty)).TrimEnd();

[pusher](https://pusher.com/tutorials/counter-aspnet)

[Reference Apps](https://github.com/dotnet-architecture)

# Javascript
### 1. Lexical scope:

### 2. Arrow Function
() => {}
```
var getA = function (a){return a};
let getA = a=> a;
let square = (a) => {return a*a};
```
The Arrow funtion uses parents this.
```
const profile = {
	firstName:'',
	lastName:'',
	setName: function(name){
		let splitName = function(n){
			let nameArray = n.split(' ');
			this.firstName = nameArray[0];// here the inner funtion is using its own this not parents's this
			this.lastName = nameArray[0];// here the inner funtion is using its own this  not parents's this
		}
		splitName(name);
	}
}
profile.setName('John Doe');
console.log(window.firstName); // Note: profile don't ahve an value
```
```
var x = function(){
 this.val =1;
 setTimeOut (function (){
  this.value++;
  console.log(this.val)
 },1);
}
var xx = new x();
```

Solution:
```
const profile = {
	firstName:'',
	lastName:'',
	setName: function(name){
		let splitName = (n) => {
			let nameArray = n.split(' ');
			this.firstName = nameArray[0];// here the inner funtion is using parents's this
			this.lastName = nameArray[0];// here the inner funtion is using parents's this
		}
		splitName(name);
	}
}
profile.setName('John Doe');
console.log(profile.firstName); // Note: profile has value
```
Arrow operators dont take first value by default;
```
var z= function(){console.log(arguments[0])};//returns 1
var z= ()=>{console.log(arguments[0])}// nothing Available
var z= function(...arguments){console.log(arguments[0])}// works 
z(1,2,3);
```
### 3. Closure
Lexical scoping allows the variable i the outer funtion are available to the inner function
Problem statement1 : What if the outer vsr is not available
Problem statement2 : what if inner function is moved to other place

[link](https://www.youtube.com/watch?v=-xqJo5VRP4A)
### var vs let
var: 
1. functional scope. at the end of the function
2. gets hoisted

eg.
```
let x= ()=>{
//var gets hoisted to the begining of the function

  if (true){
    var v = 2;
    let l= 3 // l exist in the f block
  } 
  console.log(v); 
  console.log(l);// throws an error
}
x();
```
### '==' vs '==='
1. '==' Compares vlaue
2. '===' Compares vlaue and the type

### let vs const
1. Both used to assign value;
2. Const : Don't allow to re- assign the value
3. let: Allow to re-assign value, type can also be changed
4. const as an object/ array can be modified but not re assigned
```
const t = 4;
t = 6; // invalid:throws error Assignment to constant variable
const u= [1,2,3];
u.push(5); // valid
u.pop();// valid
```
### null and undefined
1. undefined: Declared a variable and not assigned
```
typeof(null); // Object
typeof(undefined); // undefined
```
```

console.log(2-'2d'); //0
```
## Spread Operator
```
let x = [1,2,3]
let z = [...x]  
```
Onsite Oppertunity
[CompanyList](https://leetcode.com/discuss/career/1982238/List-of-international-companies-from-India-Visa-sponsorship)
