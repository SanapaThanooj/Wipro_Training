// Cart functionality
let cart = [];

function addToCart(name, price) {
  const existing = cart.find(item => item.name === name);
  if (existing) {
    existing.qty += 1;
  } else {
    cart.push({ name, price, qty: 1 });
  }
  updateCartUI();
}

function removeItem(index) {
  cart.splice(index, 1);
  updateCartUI();
}

function updateCartUI() {
  const cartItems = document.getElementById("cartItems");
  const cartTotal = document.getElementById("cartTotal");

  if (!cartItems || !cartTotal) return;

  cartItems.innerHTML = "";
  let total = 0;

  cart.forEach((item, index) => {
    const li = document.createElement("li");
    li.innerHTML = `
      ${item.name} x${item.qty} - ₹${item.price * item.qty}
      <button onclick="removeItem(${index})">Remove</button>
    `;
    cartItems.appendChild(li);
    total += item.price * item.qty;
  });

  cartTotal.textContent = `Total: ₹${total}`;
}

// Auto-update cart on page load
updateCartUI();

// Contact form
const contactForm = document.getElementById("contactForm");
if (contactForm) {
  contactForm.addEventListener("submit", function (e) {
    e.preventDefault();
    const name = document.getElementById("name").value.trim();
    const email = document.getElementById("email").value.trim();
    const message = document.getElementById("message").value.trim();
    if (name && email && message) {
      alert(`Thank you for your message, ${name}!`);
      contactForm.reset();
    } else {
      alert("Please fill all fields.");
    }
  });
}

// Payment form
const payForm = document.getElementById("payForm");
if (payForm) {
  payForm.addEventListener("submit", function (e) {
    e.preventDefault();
    document.getElementById("payMessage").textContent =
      "Payment Successful! Thank you for your order.";
    payForm.reset();
  });
}

