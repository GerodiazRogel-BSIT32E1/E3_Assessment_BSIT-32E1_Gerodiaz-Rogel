function checkNumber() {
    var num = document.getElementById('num').value;
    var result = document.getElementById('result');
     if (num % 2 == 0) {
     result.textContent = num + " is even.";
      } else {
       result.textContent = num + " is odd.";
      }
    }
    