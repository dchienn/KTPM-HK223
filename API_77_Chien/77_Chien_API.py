from flask import Flask, jsonify, request
import json

app = Flask(__name__)

# Load data from JSON file
def load_data():
    try:
        with open('data_77_Chien.json', 'r') as file:
            data = json.load(file)
        return data
    except FileNotFoundError:
        return {"message": "File not found"}
    except json.JSONDecodeError:
        return {"message": "Invalid JSON format"}

# Save data to JSON file
def save_data(data):
    with open('data_77_Chien.json', 'w') as file:
        json.dump(data, file, indent=4)

# GET method to retrieve all data
@app.route('/api/data', methods=['GET'])
def get_data():
    data = load_data()
    return jsonify(data)

# POST method to add new data
@app.route('/api/data', methods=['POST'])
def add_data():
    try:
        new_data = request.json
        current_data = load_data()
        current_data.append(new_data)
        save_data(current_data)
        return jsonify({"message": "Data added successfully", "data": new_data}), 201
    except Exception as e:
        return jsonify({"error": str(e)}), 500

# PUT method to update existing data
@app.route('/api/data/<int:data_id>', methods=['PUT'])
def update_data(data_id):
    try:
        updated_data = request.json
        current_data = load_data()
        for item in current_data:
            if item.get('id') == data_id:
                item.update(updated_data)
                save_data(current_data)
                return jsonify({"message": "Data updated successfully", "data": item}), 200
        return jsonify({"message": "Data not found"}), 404
    except Exception as e:
        return jsonify({"error": str(e)}), 500

# DELETE method to delete existing data
@app.route('/api/data/<int:data_id>', methods=['DELETE'])
def delete_data(data_id):
    try:
        current_data = load_data()
        for item in current_data:
            if item.get('id') == data_id:
                current_data.remove(item)
                save_data(current_data)
                return jsonify({"message": "Data deleted successfully", "data": item}), 200
        return jsonify({"message": "Data not found"}), 404
    except Exception as e:
        return jsonify({"error": str(e)}), 500

if __name__ == '__main__':
    app.run(debug=True)
