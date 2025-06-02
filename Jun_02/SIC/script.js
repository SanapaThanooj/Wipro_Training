document.getElementById("interestForm").addEventListener("submit", function(e) {
  e.preventDefault();

  const principal = parseFloat(document.getElementById("principal").value);
  const rate = parseFloat(document.getElementById("rate").value);
  const time = parseFloat(document.getElementById("time").value);

  if (principal > 0 && rate > 0 && time > 0) {
    const interest = (principal * rate * time) / 100;
    const total = principal + interest;

    document.getElementById("result").innerHTML = `
      Interest: ₹${interest.toFixed(2)}<br>
      Total Amount: ₹${total.toFixed(2)}
    `;
  } else {
    document.getElementById("result").innerText = "Please enter valid values.";
  }
});