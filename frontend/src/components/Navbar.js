import React, { Component } from 'react';
import cart from '../cart.svg';
import 'bootstrap/dist/css/bootstrap.css';

export default class Navbar extends Component {
    render() {
        return (
            <div>
                <nav className="navbar navbar-expand-lg navbar-light bg-light d-flex justify-content-around">
                    <a className="navbar-brand" href="/">SneakerHead</a>

                    <form className="form-inline my-2 my-lg-0">
                        <input className="form-control" type="search" placeholder="Search" aria-label="Search"/>
                        <div className="input-group-append">
                            <button className="btn btn-outline-secondary" type="button">Search</button>
                        </div>
                    </form>

                    <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>

                    <div className="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul className="navbar-nav">
                            <li className="nav-item active">
                                <a className="nav-link" href="/">Home <span className="sr-only">(current)</span></a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="/">Shop All</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="/">Brands</a>
                            </li>
                            <li className="ml-4 mt-1">
                                <a href="/"><img src={cart} alt="Shopping Cart" /></a>
                            </li>
                        </ul>
                        
                    </div>
                </nav>
            </div>
        )
    }
}