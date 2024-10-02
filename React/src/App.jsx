import { BrowserRouter, Routes, Route } from "react-router-dom";
import "./App.css";
import Homepage from "./pages/Homepage/Homepage";
import About from "./pages/About/About";
import Navbar from "./components/Navbar/Navbar";
import ProductAdd from "./ProductCard/ProductAdd";
import ProductDetail from "./ProductCard/ProductDetail";

function App() {
	return (
		<>
		<Navbar/>
		<BrowserRouter>
			<Routes>
			<Route path="/" element={<Homepage />} />
          <Route path="/about" element={<About />} />
          <Route path="/productadd" element={<ProductAdd />} />
          <Route path="/productdetail/:id" element={<ProductDetail />} />
          <Route path="*" element={<p>Not Found</p>} />
			</Routes>
		</BrowserRouter>
		</>
	);
}
export default App;
