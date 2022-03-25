//This regular expression sample script returns the first found match in a string.
function GetRegExpMatch(patrn, strng)
{
  var array1 = strng.match(patrn);
  if (array1 === null)
    return undefined;
  else return array1[0];
}

//Usage
//Everything between the two "/", will denote the regular expression. 
//At the end the "i" means we do a case insensitive search.
myVal = GetRegExpMatch(/\d{4}/i, OCR.Extract("zone1"))