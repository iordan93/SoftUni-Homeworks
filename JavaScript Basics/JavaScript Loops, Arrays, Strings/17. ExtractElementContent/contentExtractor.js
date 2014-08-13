function replaceATag(inputString) {
var re = />[^><]+</g,
     matches = inputString.match(re),
     outputString = '',
     i;
    
     for (i in matches) {
     outputString += matches[i].replace(/[<>\s]/g,'');
     }
    
     return outputString;
}

console.log(replaceATag('<p>Hello</p><a href="http://w3c.org">W3C</a>'));