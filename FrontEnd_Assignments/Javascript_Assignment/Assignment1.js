//1
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}
let sum = 0;
for (let key in salaries){
    sum += salaries[key];
}
console.log(sum)

//2
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

function multiplyNumeric(obj){
    for (let key in obj){
        if(typeof(obj[key]) == "number"){
            obj[key] = obj[key]*2;
        }     
    }
}
multiplyNumeric(menu);
console.log(menu);

//3
function checkEmailId(str){
    const reg = /^\w+([.-]?\w+)@\w+\.\w+/;

    if(str.match(reg)){
        return true;
    }
    else{
        return false;
    }
}
let email = "jmaxwong@gmail.com";
let email2 = "jam@fqf"
console.log(checkEmailId(email));
console.log(checkEmailId(email2));

//4
function truncate(str, maxlength){
    if (str.length <= maxlength){
        return str;
    }
    else{
        return str.substring(0, maxlength) + "...";
    }
}
console.log(truncate("Hello", 4));

//5
let ls = ["James","Brennie"]

function append(ls, element){
    ls.push(element);
}

function replaceMiddle(ls, element){
    if(ls.length % 2 == 1){
        // ls[Math.floor(ls.length/2)] = element;
        ls.splice(Math.floor(ls.length/2),1,element);
    }
}

function removeFirst(ls){
    if(ls.length > 0){
        ls.shift();
    }
}

// function prepend(ls, elements){
//     ls.splice(0,0,)
//     console.log(ls);
// }

append(ls, "Robert");
console.log(ls);
replaceMiddle(ls,"Calvin");
console.log(ls);
removeFirst(ls);
console.log(ls);
// prepend(ls, ["people", "people1"]);
ls.splice(0,0,"Rose","Regal");
console.log(ls);







