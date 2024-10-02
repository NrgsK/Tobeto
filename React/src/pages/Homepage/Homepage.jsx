
import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import ProductCard from '../../components/ProductCard/ProductCard';
import axios from "axios";

export default function Homepage() {
  const [products, setProducts] = useState([]);

  useEffect(() => {
    fetchProducts();
  }, []);

  const fetchProducts = async () => {
    try {
      let response = await axios.get("https://dummyjson.com/products");
      setProducts(response.data.products);
    } catch (error) {
      console.error("Error fetching products:", error);
    }
  };

  const handleDelete = async (productId) => {
    try {
      await axios.delete(`https://dummyjson.com/products/${productId}`);
      fetchProducts(); 
    } catch (error) {
      console.error("Error deleting product:", error);
    }
  };

  return (
    <div className="container mt-5">
      <div className="row">
        {products.map(product => (
          <div key={product.id} className="col-lg-3 col-md-6 col-12 mb-5">
            <Link to={`/product-detail/${product.id}`}>
              <ProductCard product={product} onDelete={() => handleDelete(product.id)} />
            </Link>
          </div>
        ))}
      </div>
    </div>
  );
}
