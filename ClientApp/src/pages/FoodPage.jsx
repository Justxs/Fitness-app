import React from 'react';
import CaloryEntry from '../components/FoodPage_components/CaloryEntry';
import EatenFoodList from '../components/FoodPage_components/EatenFoodList';

function FoodPage() {
  return (
    <div className='Food_page'>
        <CaloryEntry />
        <EatenFoodList />
    </div>
  )
}

export default FoodPage