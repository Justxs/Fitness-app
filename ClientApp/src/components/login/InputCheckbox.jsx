function InputCheckbox({
  onChange,
  name,
  value,
  description,
  disabled,
  required,
}) {
  return (
    <div>
      <label htmlFor={name}>{description}</label>
      <div className="input-group mb-3">
        <input
          type="checkbox"
          className="form-check-input"
          id={name}
          name={name}
          checked={value}
          onChange={(e) => onChange(e)}
          disabled={disabled}
          required={required}
        />
      </div>
    </div>
  );
}

export default InputCheckbox;
