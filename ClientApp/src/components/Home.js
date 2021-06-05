import React, { Component } from 'react';
import {Post} from './Post';
export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Reviews</h1>
        <p>Search reviews</p>
        <Post/>
      </div>
    );
  }
}
