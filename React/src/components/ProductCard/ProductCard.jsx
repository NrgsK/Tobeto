
import React from 'react';
import { Link } from 'react-router-dom';
import ProductAdd from './ProductAdd'; 
import ProductDetail from './ProductDetail'; 

export default function ProductCard(props) {
  const { id, thumbnail, title, description } = props.product;

  return (
    <div className="card">
      <img src={thumbnail} className="card-img-top" alt={title} />
      <div className="card-body">
        <h5 className="card-title">{title}</h5>
        <p className="card-text">{description}</p>
        <Link to={`/product-detail/${id}`} className="btn btn-primary">Details</Link>
        <Link to="/add-product" className="btn btn-success">Add Product</Link>
        <button onClick={props.onDelete} className="btn btn-danger">Delete</button>
      </div>
    </div>
  );
}
